using weapon;
using monster;
public class Attack
{
   public weapon.Weapon Weapon;
    public monster.Monster Monster;

    public Attack(monster.Monster monster, weapon.Weapon weapon)
    {
        Monster = monster;
        Weapon = weapon;
    }   
}