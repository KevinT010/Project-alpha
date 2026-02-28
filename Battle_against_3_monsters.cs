public class Battle_against_3_monsters
{
    public static void FightMonsters(Player player, int monsterID, string monsterName, int amount)
    {
        Monster? monster = World.MonsterByID(monsterID);
        if (monster == null)
        {
            Console.WriteLine($"Error: {monsterName} monster not found.");
            return;
        }

        for (int i = 1; i <= amount; i++)
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine($"BATTLE {i} OF {amount} STARTS");
            Console.WriteLine("===================================");

            monster.CurrentHitPoints = monster.MaximumHitPoints;

            string result = Battle.StartFight(player, monster);

            if (result == "Defeat")
            {
                Console.WriteLine($"\nThe {monsterName}s overwhelmed you. Game Over.");
                break;
            }
            else if (result == "Escaped")
            {
                Console.WriteLine($"\nYou ran away! The remaining {monsterName}s are still out there.");
                break;
            }
            else if (result == "Victory")
            {
                Console.WriteLine($"\nYou defeated {monsterName} #{i}!");

                if (i == amount && result == "Victory")
                {
                    Console.WriteLine($"\nCongratulations! You cleared the area of all the {monsterName}s!");
                }
                else
                {
                    Console.WriteLine("Get ready. here comes the next one!");
                }
            }
        }
    }
}