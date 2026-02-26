namespace weapon;

public class Reward(int gold, Weapon? weaponReward = null)
{
    public int Gold = gold;
    public Weapon? WeaponReward = weaponReward;

    public void DisplayReward()
    {
        Console.WriteLine("\n--- Quest Reward ---");
        Console.WriteLine($"Gold: +{Gold}");
        
        if (WeaponReward != null)
        {
            Console.WriteLine($"Weapon: {WeaponReward.Name}");
        }
    }
}

public static class RewardSystem
{
    public static Reward GetQuestReward(int questID) => questID switch
    {
        World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN => new Reward(25, World.WeaponByID(1)),
        World.QUEST_ID_CLEAR_FARMERS_FIELD => new Reward(50, World.WeaponByID(2)),
        World.QUEST_ID_COLLECT_SPIDER_SILK => new Reward(75, World.WeaponByID(3)),
        _ => new Reward(0)
    };
    public static Reward GetMonsterReward(int monsterID) => monsterID switch
    {
        World.MONSTER_ID_RAT => new Reward(10),
        World.MONSTER_ID_SNAKE => new Reward(25),
        World.MONSTER_ID_GIANT_SPIDER => new Reward(50),
        _ => new Reward(0)
    };
}