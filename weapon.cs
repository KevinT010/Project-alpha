namespace weapon;

using monster;
public class Weapon
{
    public int ID;
    public string Name;
    public int MaximumDamage;

    public Weapon(int id, string name, int maximumDamage)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
    }

    private static Random random = new Random();

    public void Attack(int maximumDamage, Monster monster, bool isCriticalHit = false)
    {
        int damage = random.Next(1, maximumDamage);
        bool isCritical = random.NextDouble() < 0.4;

        if (isCriticalHit || isCritical)
        {
            damage *= 2;
            Console.WriteLine($"You land a critical hit on the {monster.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"You attack the {monster.Name} for {damage} damage.");
        }

        monster.CurrentHitPoints -= damage;
    }

}