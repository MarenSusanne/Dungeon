namespace Dungeon;

internal class Game
{
    private Player _player = new Player();
    private string _currentRoom;
    public void GameMenu()
    {
        while (true)
        { 
            Console.WriteLine("Welcome to the dungeon crawler!\nWhat would you like to do?\n" +
                            "   1. Rules\n" + 
                            "   2. Enter Dungeon\n" + 
                            "   3. Exit");
            var resonse = Console.ReadLine();
            switch (resonse)
            {
                case "1":
                    Rules();
                    break;
                case "2":
                    _player.EnterDungeon();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    Thread.Sleep(500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            } 
        }

    }
    public void Rules()
    {
        Console.WriteLine("To be determined!");
    }

    public void ChangeRoom()
    {
        switch (_currentRoom)
        {
            case "Arcane Chamber":
                break;
            case "Monster Room":
                break;
            case "Treasure Room":
                break;
            case "Trick Room":
                break;
            case "Healing Room":
                break;
            case "Prison Room":
                break;
            case "Garden Room":
                break;
            case "Shop Room":
                break;
            case "Trap Room":
                break;
            case "Frost Room":
                break;
        }
    }


}