using System;

class Program
{
    static void Main()
    {
        Random dice = new Random();
        int roll = dice.Next(1, 21);

        Console.WriteLine("Would you like to roll the dice? (yes) or (no)");

        var input = Console.ReadLine();

        if (input == "yes")
        {
            Game(dice);
        }
        else if (input == "no")
        {
            Environment.Exit(0);
        }
    }

    static void Game(Random dice)
    {
        int roll = dice.Next(1, 21);

        Console.WriteLine(roll);

        if (roll >= 1 && roll <= 5)
        {
            Console.WriteLine("Bad Luck!");
        }
        else if (roll >= 6 && roll <= 10)
        {
            Console.WriteLine("Maybe next roll?");
        }
        else if (roll >= 11 && roll <= 15)
        {
            Console.WriteLine("Do it again, you almost had it!");
        }
        else if (roll >= 16 && roll <= 19)
        {
            Console.WriteLine("Ohhhh!!! So Close!");
        }
        else if (roll == 20)
        {
            Console.WriteLine("You Win!");
            Console.WriteLine("(exit)");
            var leaves = Console.ReadLine();
            if (leaves == "exit")
            {
                Environment.Exit(0);
            }
        }

        Console.WriteLine("Roll again? (yes) or (no)");
        var rollagain = Console.ReadLine();
        if (rollagain == "yes")
        {
            Game(dice);
        }
        else if (rollagain == "no")
        {
            Environment.Exit(0);
        }
    }
}
