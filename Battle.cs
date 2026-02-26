using weapon;
using monster;
using player;

public static class Battle
{
    public static void StartFight(Player player, Monster monster)
    {
        Console.WriteLine("===================================");
        Console.WriteLine($"A wild {monster.Name} appears!");
        Console.WriteLine("===================================");

        while (player.CurrentHitPoints > 0 && monster.currentHitPoints > 0)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"{player.Name} HP: {player.CurrentHitPoints}/{player.MaximumHitPoints}");
            Console.WriteLine($"{monster.Name} HP: {monster.currentHitPoints}/{monster.maximumHitPoints}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Flee");
            Console.Write("> ");

            string choice = Console.ReadLine() ?? string.Empty;

            if (choice == "1")
            {
                Console.WriteLine($"\nYou grip your {player.CurrentWeapon.Name} tightly.");
                player.CurrentWeapon.Attack(player.CurrentWeapon.MaximumDamage, monster);

                if (monster.currentHitPoints > 0)
                {
                    Console.WriteLine($"\nThe {monster.Name} growls and prepares to strike!");
                    monster.Attack(monster.MaximumDamage, player);
                }
            }
            else if (choice == "2")
            {
                monster.Flee(player);
                Console.WriteLine("You barely escape with your life!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }

        if (player.CurrentHitPoints <= 0)
        {
            player.CurrentHitPoints = 0;
            Console.WriteLine("\nYou have been defeated.");
        }
        else if (monster.currentHitPoints <= 0)
        {
            monster.currentHitPoints = 0;
            Console.WriteLine($"\nYou defeated the {monster.Name}!");
        }
    }
}