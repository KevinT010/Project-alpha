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
        Random random = new Random();
        int damage = random.Next(1, maximumDamage);
        player.CurrentHitPoints -= damage;
        Console.WriteLine($"The {Name} attacks you for {damage} damage.");
    }

    public void Flee(Player player)
    {
        player.CurrentHitPoints -= 10;
        Console.WriteLine($"You flee from the {Name}!");
    }
}