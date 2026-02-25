namespace monster;

public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
   
   public int currentHitPoints;

   public int maximumHitPoints;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        this.currentHitPoints = currentHitPoints;
        this.maximumHitPoints = maximumHitPoints;
        
    }

    public void Attack(int maximumDamage)
    {
        Random random = new Random();
        int damage = random.Next(1, maximumDamage);
        //currentHitPoints -= damage;
        Console.WriteLine($"The {Name} attacks you for {damage} damage.");
    }
}