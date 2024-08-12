namespace Dungeon;

public class Player
{
    private int _strenght { get; set; }
    private int _dexterity { get; set; }
    private int _constitution { get; set; }
    private int _intelligence { get; set; }
    private int _wisdom { get; set; }
    private int _charisma { get; set; }
    private int _health { get; set; }
    private int _armour { get; set; }

    public Player()
    {
        _strenght = 10;
        _dexterity = 10;
        _constitution = 10;
        _intelligence = 10;
        _wisdom = 10;
        _charisma = 10;
        _health = 100;
        _armour = 10;
    }

    public void EnterDungeon()
    {
        Console.WriteLine("Entering the dimly lit dungeon, the air thickens with damp earth and ancient stone.\n" +
                          "Flickering torches cast eerie shadows as distant echoes and unseen creatures break the silence.\n" +
                          "Each step forward promises peril and treasure.");

        Console.WriteLine("\nAs you round the corner, you find a small, dimly lit room with three distinct doors.\n\n" +
                          "To the left, an aged oak door with glowing runes hums with magical energy.\n\n" +
                          "Straight ahead, a heavy iron door, marred by deep claw marks, promises ferocity.\n\n" +
                          "To the right, a plain wooden door with a brass handle emanates an inexplicable foreboding.\n\n" +
                          "The choice is yours: mystic secrets, brute force, or hidden dangers?");
        var doorChoice = Console.ReadLine();
        if (doorChoice.ToLower() == "left" || doorChoice.ToLower() == "mystic secrets")
        {

        }
        else if (doorChoice.ToLower() == "straight ahead" || doorChoice.ToLower() == "brute force" || doorChoice.ToLower() == "middle")
        {

        }
        else if (doorChoice.ToLower() == "right" || doorChoice.ToLower() == "hidden dangers")
        {

        }
    }
}