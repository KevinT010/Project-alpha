namespace weapon;
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

    public void Attack(int maximumDamage)
    {
        Random random = new Random();
        int damage = random.Next(1, maximumDamage);
        //CurrentHitPoints -= damage;
        Console.WriteLine($"You attack the {Name} for {damage} damage.");
    }

    public void CriticalHit(int maximumDamage)
    {
        Random random = new Random();
        int damage = random.Next(1, maximumDamage) * 2;
        //CurrentHitPoints -= damage;
        Console.WriteLine($"You land a critical hit on the {Name} for {damage} damage!");
    }

}