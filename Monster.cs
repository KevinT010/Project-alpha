namespace monster;

using player;

public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;

    }
    private static Random random = new Random();
    public void Attack(int maximumDamage, Player player)
    {
        int damage = random.Next(1, maximumDamage);
        player.CurrentHitPoints -= damage;
        Console.WriteLine($"The {Name} attacks you for {damage} damage.");
    }

    public void Flee(Player player)
    {
        if (player.CurrentHitPoints > 0)
        {
            player.CurrentHitPoints -= 10;

            if (player.CurrentHitPoints < 0)
            {
                player.CurrentHitPoints = 0;
            }
        }
        else if (player.CurrentHitPoints < 0)
        {
            player.CurrentHitPoints = 0;
        }
    }
}