public class Location
{
    // 1. Declaring fields.

    // basic fields    
    public int ID;
    public string Name;
    public string Description;

    // object fields || Nog niet aangemaakt
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;
    

    // 2. Set values with constructor.
    
    public Location(int id, string name, string description Quest quest, Monster monster) {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.QuestAvailableHere = quest;
        this.MonsterLivingHere = monster;
    }
}