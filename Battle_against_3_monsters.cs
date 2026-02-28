public class Battle_against_3_monsters
{
    public static void FightMonsters(Player player, int monsterID, string monsterName, int amount, Quest quest)
    {
        Monster? monster_template = World.MonsterByID(monsterID);
        if (monster_template == null)
        {
            Console.WriteLine($"Error: {monsterName} monster not found.");
            return;
        }

        bool allDefeated = true;

        for (int i = 1; i <= amount; i++)
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine($"BATTLE {i} OF {amount} STARTS");
            Console.WriteLine("===================================");

            Monster monster = new Monster(
                monster_template.ID,
                monster_template.Name,
                monster_template.MaximumDamage,
                monster_template.CurrentHitPoints,
                monster_template.MaximumHitPoints
            );

            string result = Battle.StartFight(player, monster);

            if (result == "Defeat")
            {
                Console.WriteLine($"\nThe {monsterName}s overwhelmed you. Game Over.");
                allDefeated = false;
                break;
            }

            if (result == "Escaped")
            {
                Console.WriteLine($"\nYou ran away! The remaining {monsterName}s are still out there.");
                allDefeated = false;
                break;
            }

            Console.WriteLine($"\nYou defeated {monsterName} #{i}!");

            if (i < amount)
            {
                Console.WriteLine($"Here come the next {monsterName}!");
            }
        }

        if (allDefeated)
        {
            Console.WriteLine($"\nCongratulations! You cleared the area of all the {monsterName}s!");
            quest.CompleteQuest(player);
        }
    }
}