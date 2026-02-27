public static class Rewards
{
    public class Reward
    {
        public int Coins;
        public Weapon? WeaponItem;

        public Reward(int coins, Weapon? weaponItem)
        {
            Coins = coins;
            WeaponItem = weaponItem;
        }
    }

    private static readonly Dictionary<int, Reward> QuestRewards = new Dictionary<int, Reward>();

    public static void GiveRewards()
    {

        QuestRewards.Add(World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN, new Reward(20, World.WeaponByID(1)));
        QuestRewards.Add(World.QUEST_ID_CLEAR_FARMERS_FIELD, new Reward(50, World.WeaponByID(2)));
        QuestRewards.Add(World.QUEST_ID_COLLECT_SPIDER_SILK, new Reward(100, World.WeaponByID(3)));
    }

    public static void QuestReward(Player player, int questId)
    {
        if (QuestRewards.ContainsKey(questId))
        {
            Reward reward = QuestRewards[questId];
            
            Console.WriteLine("\n*** QUEST COMPLETE! ***");
            
            player.Coins += reward.Coins;
            Console.WriteLine($"You received {reward.Coins} coins");
            Console.WriteLine($"Total Coins: {player.Coins}");

            if (reward.WeaponItem != null)
            {
                player.Inventory.Add(reward.WeaponItem);
                Console.WriteLine($"You received a {reward.WeaponItem.Name}!");
            }
            
        }
    }
}