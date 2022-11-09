using ConsoleApp2;
using System.Drawing;

class Program
{
    static void Main()
    { 
        List<Animal> animals = new List<Animal>();
        animals.Add(new Horse {
            Name = "Плотва",
            LeatherType = "Мягкая кожа",
            Color = Color.Black});

        animals.Add(new Parrot {
            Name = "Бэби Джон",
            Color = Color.Yellow
        });

        animals.Add(new Duck
        {
            IsAlive = false,
            Name = "Скрудж МакДак"
        });

        animals.Add(new Snake {
            Name = "Python",
            IsAlive = false
        });

        if (animals[3] is IRunAble)
            ((IRunAble)animals[3]).Run();
        else if (animals[3] is ICrawlAble crawlAble)
            crawlAble.Crawl();
            
        foreach (Animal animal in animals)
        {
            if (animal is IFlyAble fly)
                fly.Fly();
            if (animal is ISwimAble swim)
                swim.Swim();
        }
    }
}