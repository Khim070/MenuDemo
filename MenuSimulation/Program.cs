namespace MenuSimulation;

internal class Program
{
    static void Main(string[] args)
    {
        Helper.MenuBank.MenuSimulate(() => { Console.WriteLine(); });
    }
}
