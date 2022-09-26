using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int playerhealth;
        int enemyhealth;
        int playerstrength;
        int enemystrength;
        int enemychoice;

        playerhealth = 200;
        enemyhealth = 200;
        playerstrength = 100;
        enemystrength = 20;
        string varFight;

        Console.WriteLine("Does the player want to fight");
        varFight = Console.ReadLine();
        if (varFight == "yes")
        {
            Console.WriteLine("Your enemy approches");
            Console.WriteLine("The battle begins");
            while (enemyhealth > 0)
            {
                playerstrength = 100;
                enemystrength = 20;
                Console.WriteLine("Are you attcking or defending");
                string attDef;

                attDef = Console.ReadLine();
                if (attDef == "attack")
                {
                    Console.WriteLine("you have decided to attack");
                }
                else
                {
                    Console.WriteLine("you have decided to defend");
                    enemystrength = 0;
                    playerstrength = 0;
                }
                enemychoice = random.Next(2);
                if (enemychoice == 1)
                {
                    Console.WriteLine("Your enemy attacks you");
                }
                else
                {
                    Console.WriteLine("Your enemy defends");
                    playerstrength = 0;
                    enemystrength = 0;
                }
                enemyhealth = enemyhealth - playerstrength;
                playerhealth = playerhealth - enemystrength;
                Console.WriteLine("enemy health is " + enemyhealth);
                Console.WriteLine("player health is " + playerhealth);
            }
            Console.WriteLine("you won the battle");
        }
        else
        {
            Console.WriteLine("you skip the battle");
        }
    }

    public static void End()
    {
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
