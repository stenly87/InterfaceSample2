using ConsoleApp2;

internal class Snake : Animal, ISwimAble, ICrawlAble
{
    public void Crawl()
    {
        Console.WriteLine($"Змея {Name} ползет в лучшую жизнь"); 
    }

    public void Swim()
    {
        Console.WriteLine();
    }
}