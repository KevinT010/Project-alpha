using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello adventurer, what is your name?");
        string name = Console.ReadLine();

        // if name is empty ask name again
        // inplement later ? 

        Player player = new Player(
            name,
            100,
            100,
            World.WeaponByID(1),
            World.LocationByID(World.LOCATION_ID_HOME),
            new List<string>(),
            new List<string>(), 
            0);


        Console.WriteLine($"Welcome {player.Name}!");

        bool isPlaying = true;

        while (isPlaying)
        {
            Console.WriteLine($"\nYou are at {player.CurrentLocation.Name}");
            Console.WriteLine($"{player.CurrentLocation.Description}");

            Console.WriteLine($"\nWhat would u like to do?");
            Console.WriteLine($"1. See game stats");
            Console.WriteLine($"2. Travel to new location");

            Console.WriteLine($"3. Quit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\n--- GAME STATS ---");
                    Console.WriteLine($"Name: {player.Name}");
                    Console.WriteLine($"HP: {player.CurrentHitPoints}/{player.MaximumHitPoints}");
                    Console.WriteLine($"Weapon: {player.CurrentWeapon.Name}");
                    Console.WriteLine($"Coins: {player.Coins}");
                    Console.WriteLine($"Current quest(s): {Convert.ToString(player.CurrentQuests)}");
                    Console.WriteLine($"Quests completed: {player.CompletedQuests.Count}");
                    break;
                case "2":
                    Travel(player);
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    isPlaying = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
    // Methods ---------------------------------- 

    public static void Travel(Player player)
    {
        Console.WriteLine($"\nYou are now at: {player.CurrentLocation.Name}.\nFrom here you can go:\n");
        
        if(player.CurrentLocation.LocationToNorth != null)
        {
            Console.WriteLine($"N - North: {player.CurrentLocation.LocationToNorth.Name}");
        }
        if(player.CurrentLocation.LocationToEast != null)
        {
            Console.WriteLine($"E - East: {player.CurrentLocation.LocationToEast.Name}");
        }
        if(player.CurrentLocation.LocationToSouth != null)
        {
            Console.WriteLine($"S - South: {player.CurrentLocation.LocationToSouth.Name}");
        }
        if(player.CurrentLocation.LocationToWest != null)
        {
            Console.WriteLine($"W - West: {player.CurrentLocation.LocationToWest.Name}");
        }

        Console.WriteLine("> "); 
        string direction = Console.ReadLine().ToUpper();

        switch (direction)
        {
            case "N":
                player.MoveToNorth();
                break;
            case "E":
                player.MoveToEast();
                break;
            case "S":
                player.MoveToSouth();
                break;
            case "W":
                player.MoveToWest();
                break;
            default:
                Console.WriteLine("Invalid direction!");
                break;
        }
        Console.WriteLine($"You are now at: {player.CurrentLocation.Name}");
        if(player.CurrentLocation.QuestAvailableHere != null)
        {
            player.CurrentLocation.QuestAvailableHere.ActivateQuest(player);
        }


    }

    // codition triggerd -> public void ActivateQuest(Player player)
    
    // if quest is available -> public void ActivateQuest(Player player)
    // { public static void Travel(Player player) }

    // move to battle area 
    // public static void FightMonsters(Player player, int monsterID, string monsterName, int amount, Quest quest) || battle_against3_monsters.cs
    
    // (result van questavailablehere ).activatequest  || locations.cs {}
    
    

}