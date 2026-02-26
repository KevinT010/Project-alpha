namespace battle;
using monster;
using player;

public static class Battle
{
    public static string StartFight(Player player, Monster monster)
    {
        Console.WriteLine("===================================");
        Console.WriteLine($"A wild {monster.Name} appears!");
        Console.WriteLine("===================================");

        while (player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"{player.Name} HP: {player.CurrentHitPoints}/{player.MaximumHitPoints}");
            Console.WriteLine($"{monster.Name} HP: {monster.CurrentHitPoints}/{monster.MaximumHitPoints}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("What do you want to do attack or flee?");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Flee (lose 10 HP)");
            Console.Write("> ");

            string choice = Console.ReadLine() ?? string.Empty;

            if (choice == "1")
            {
                Console.WriteLine($"\nYou grip your {player.CurrentWeapon.Name} tightly.");
                player.CurrentWeapon.Attack(player.CurrentWeapon.MaximumDamage, monster);

                if (monster.CurrentHitPoints > 0)
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
            return "Defeat";
        }
        else if (monster.CurrentHitPoints <= 0)
        {
            monster.CurrentHitPoints = 0;
             return "Victory";
        }
        else if(player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0)
        {
            return "Escaped";
        }

        return "Unknown";
    }
}