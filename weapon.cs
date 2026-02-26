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

    public void Attack(int maximumDamage, Monster monster)
    {
        Random random = new Random();
        int damage = random.Next(1, maximumDamage);
        monster.currentHitPoints -= damage;
        Console.WriteLine($"You attack the {monster.currentHitPoints} for {damage} damage.");
    }

    public void CriticalHit(int maximumDamage, Monster monster)
    {
        Random random = new Random();
        int damage = random.Next(1, maximumDamage) * 2;
        monster.currentHitPoints -= damage;
        Console.WriteLine($"You land a critical hit on the {Name} for {damage} damage!");
    }

}