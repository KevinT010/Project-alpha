using System.ComponentModel;
using System.Dynamic;
namespace player;
using weapon;

public class Player
{

    // 1. Declaring fields.

    // basic fields    
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    
    // object fields || Nog niet aangemaakt
    public Weapon CurrentWeapon;
    public Location CurrentLocation;
    
    public Player(string name, int CurrentHitPoints, int MaximumHitPoints, Weapon weapon, Location CurrentLocation)
    {
        this.Name = name;
        this.CurrentHitPoints = CurrentHitPoints;
        this.MaximumHitPoints = MaximumHitPoints; 
        this.CurrentWeapon = weapon;
        this.CurrentLocation = CurrentLocation;
    }

    // public static void 

}