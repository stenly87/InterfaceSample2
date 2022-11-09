using ConsoleApp2;
using System.Drawing;

internal class Parrot : Animal, IFlyAble, IRunAble
{
    public Parrot()
    {
        LifeAction = ParrotLifeAction;
    }
    Random random = new Random();
    private void ParrotLifeAction()
    {
        Console.WriteLine($"{Name}: Кар, тьфу, привет"); ;
        if (random.NextDouble() < 0.025)
        {
            IsAlive = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} подавился и сдох");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public void Fly()
    {
        Console.WriteLine($"Попугай {Name} летит в теплые края");
    }

    public void Run()
    {
        Console.WriteLine($"Попугай {Name} пытается бежать. Прыгает короче.");
    }

}