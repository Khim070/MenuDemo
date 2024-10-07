using MenuLib;

namespace MenuSimulation;

public static class Helper
{
    public static MenuBank MenuBank { get; set; } = new MenuBank()
    {
        Title = "Testing",
        Menus = new List<Menu>()
        {
            new Menu(){ Text= "Viewing", Action=Viewing},
            new Menu(){ Text= "Creating", Action=Creating},
            new Menu(){ Text= "Updating", Action=Updating},
            new Menu(){ Text= "Deleting", Action=Deleting},
            new Menu(){ Text= "Exiting", Action = Exiting}
        }
    };

    static Helper()
    {
       
    }

    public static void Exiting()
    {
        Console.WriteLine("\n[Exiting Program]");
        Environment.Exit(0);
    }

    private static void Deleting()
    {
        Console.WriteLine("\n[Deleting]");
        while(true)
        {
            Console.WriteLine("Doing a task to delete...");
            Console.WriteLine();
            if (WaitForEscPressed("ESC to stop or any key for more deleting...")) break;
        }
        
    }

    private static void Updating()
    {
        Console.WriteLine("\n[Updating]");
        while (true)
        {
            Console.WriteLine("Doing a task to update...");
            Console.WriteLine();
            if (WaitForEscPressed("ESC to stop or any key for more updating...")) break;
        }
    }

    private static bool WaitForEscPressed(string text)
    {
        Console.Write(text); ;
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Console.WriteLine();
        return keyInfo.Key == ConsoleKey.Escape;
    }

    private static void Creating()
    {
        Console.WriteLine("\n[Creating]");
        while (true)
        {
            Console.WriteLine("Doing a task to create...");
            Console.WriteLine();
            if (WaitForEscPressed("ESC to stop or any key for more creating...")) break;
        }
    }
    
    private static void Viewing()
    {
        Console.WriteLine("\n[Viewing]");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.WriteLine();
    }
}
