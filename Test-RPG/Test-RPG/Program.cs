namespace Test_RPG;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("John");
        Console.WriteLine(player.getHealth());
        
        Console.WriteLine("Do you want to fight");
        Console.WriteLine("Yes or No");
        
        string input = Console.ReadLine();
        if (input == "Yes")
        {
            player.changeHealth(-10);
            Console.WriteLine("Your health is now " + player.getHealth());
        }
    }
}