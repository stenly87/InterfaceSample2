using ConsoleApp2;
using System.Drawing;

internal class Parrot : Animal, IFlyAble, IRunAble
{
    public void Fly()
    {
        Console.WriteLine($"Попугай {Name} летит в теплые края");
    }

    public void Run()
    {
        Console.WriteLine($"Попугай {Name} пытается бежать. Прыгает короче.");
    }

}