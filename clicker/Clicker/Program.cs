int points = 0;
int totalPoints = 0;
int power = 1;
int reset = 1;

Console.Clear();
for (ConsoleKeyInfo keypress = Console.ReadKey(); !string.Equals(keypress.KeyChar.ToString(), "x"); keypress = Console.ReadKey())
{
    Console.Clear();
    if (string.Equals(keypress.KeyChar.ToString(), " "))
    {
        points += power * reset;
        totalPoints++;
        Console.Write("You have " + points + " points");
        if (totalPoints % 50 == 0)
        {
            power++;
            Console.Clear();
            Console.Write("Your power has increased!");
        }
        if (totalPoints % 250 == 0)
        {
            reset++;
            points = 0;
            power = 1;
            Console.Clear();
            Console.Write("You have reset! Now you will gain points much faster.");
        }
    }
    else if (string.Equals(keypress.KeyChar.ToString(), "u"))
    {
        Console.Clear();
        if (points >= 100)
        {
            power += 1;
            points -= 100;
            Console.Write("You have upgraded! Now you will gain points faster.");
        }
        else
        {
           Console.Write("You do not have enough points to upgrade.");
        }
    }
    else if (string.Equals(keypress.KeyChar.ToString(), "s"))
    {
        Console.Write("You have " + points + " points, " + power + " power," + " and have reset " + (reset - 1) + " times.");
    }
    else if (string.Equals(keypress.KeyChar.ToString(), "?"))
    {
        Console.Write("Type 'space' to increase your points, 'u' to upgrade, '?' for help, 's' to see your stats, and 'x' to exit.");
    }
    else
    {
        Console.Write("Type '?' for help.");
    }
}
Console.Clear();
Console.Write("Thanks for playing.");