using System.ComponentModel;

public class Player
{
    // Fields
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;

    // Constructor
    public Player(string name, int currentHitPoints, int maximumHitPoints, Weapon weapon, Location location)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.MaximumHitPoints = maximumHitPoints;
        this.CurrentWeapon = weapon;
        this.CurrentLocation = location;
    }


    // use currentlocation
    // update current location

    public void MoveToNorth()
    {
        if (CurrentLocation.LocationToNorth != null)
        {
            CurrentLocation = CurrentLocation.LocationToNorth;
        }
        else
        {
            Console.WriteLine("You can't move this way!");
        }
    }    
    
    public void MoveToEast()
    {
        if(CurrentLocation.LocationToEast != null)
        CurrentLocation = CurrentLocation.LocationToEast;
        else
        {
            Console.WriteLine("You can't move this way!");
        }
    }
    
    public void MoveToSouth()
    {
        if(CurrentLocation.LocationToSouth != null)
        {
            Console.WriteLine("You can't move this way!");
        }
    }
    public void MoveToWest()
    {
        if(CurrentLocation.LocationToWest != null)
        {
            Console.WriteLine("You can't move this way!"); 
        }
    }
    




    // public static void moveToEast(){}
    
    // public static void moveToSouth(){}
    
    // public static void moveToWest(){}

    
}