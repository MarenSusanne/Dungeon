namespace Dungeon;

public class Monsters
{
    private List<Loot> loot;
    private string _type { get; set; }
    private int _health { get; set; }
    private int strenght { get; set; }

    public Monsters()
    {
        loot = new List<Loot>()
        {

        };
    }
}