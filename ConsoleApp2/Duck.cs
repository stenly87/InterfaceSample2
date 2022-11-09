using ConsoleApp2;
using System.Drawing;

internal class Duck : Animal, IFlyAble, ISwimAble, IRunAble
{
    public void Fly()
    {
        Console.WriteLine($"Утка {Name} машет крыльями и, кажется, взлетает");
    }

    public void Run()
    {
        Console.WriteLine($"Утка {Name} машет крыльями и бежит");
    }

    public void Swim()
    {
        Console.WriteLine($"Утка {Name} плавает");
    }

}