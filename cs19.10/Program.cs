using System;

namespace Lesson3;
interface IFlyable
{
    void Fly();
}
interface ISwimable
{
    void Swim();
}
abstract class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }
    public abstract void Eat();
    public abstract void Sleep();
    public abstract void Sound();
}

class Parrot : Bird, IFlyable
{
    public Parrot(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} їсть пюре");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} спить у пентхаусі");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} каже: лаллалала ");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} літає по пентхаусу");
    }
}

class Chicken : Bird
{
    public Chicken(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} їсть все шо можна");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} спить у коробці");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} каже: кукукукукуку");
    }
}

class Pinquin : Bird, ISwimable
{
    public Pinquin(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} їсть рибу");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} спить на камені.");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} каже: я не знаю какие звуки издают пінгвини");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} плаває в воді");
    }
}

class Duck : Bird, IFlyable, ISwimable
{
    public Duck(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} їсть хліб у воді");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} спить у камишах ");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} каже: кря кря кря кря ");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} летить у нове болото");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} плаває по озеру");
    }
}

/*
interface IPrintable
{
    public void Print();
}

abstract class Document
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; set; } = String.Empty;

    protected Document() { }

    protected Document(string title)
    {
        Title = title;
    }

    public void ShowText()
    {
        Console.WriteLine($"Text Document {Title} {Id}");
    }

    public abstract void ShowInfo();
}

class ElDocument : Document
{
    public ElDocument() { }
    public ElDocument(string title) : base(title) { }

    public override void ShowInfo()
    {
        Console.WriteLine("Show Info ElDocument ");
    }
}

class RealDocument : Document
{
    public RealDocument() { }
    public RealDocument(string title) : base(title) { }

    public override void ShowInfo()
    {
        Console.WriteLine("Show Info RealDocument ");
    }
}

class Printer
{
    private Document? _doc = null;

    public Printer(Document doc)
    {
        this._doc = doc;
    }

    public void DoPrint()
    {
        _doc?.ShowInfo();
    }
}
*/

internal class Program
{
    static void Main(string[] args)
    {
        
        Bird[] birds = new Bird[]
        {
            new Parrot("папуга"),
            new Chicken("макчикен"),
            new Pinquin("пингвин"),
            new Duck("качка")
        };

       
        foreach (Bird bird in birds)
        {
            Console.WriteLine($"=== Інформація про: {bird.Name} ===");
            bird.Sound();
            bird.Eat();
            bird.Sleep();
            if (bird is IFlyable flyableBird)
            {
                flyableBird.Fly();
            }

            if (bird is ISwimable swimmableBird)
            {
                swimmableBird.Swim();
            }

            Console.WriteLine();
        }

        /*
        ElDocument doc2 = new ElDocument("My jupyter notebook");
        RealDocument doc3 = new RealDocument("My Real notebook");
        Printer printer = new Printer(doc3);
        printer.DoPrint();
        */
    }

    /*
    static void FillArray(int[,] arr2D, int min = 10, int max = 99)
    {
        Random r = new Random();
        for (uint i = 0; i < arr2D.GetLength(0); i++)
        {
            for (uint j = 0; j < arr2D.GetLength(1); j++)
            {
                arr2D[i, j] = r.Next(min, max);
            }
        }
    }

    static void ShowArray(int[,] arr2D)
    {
        for (uint i = 0; i < arr2D.GetLength(0); i++)
        {
            for (uint j = 0; j < arr2D.GetLength(1); j++)
            {
                Console.Write($"{arr2D[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void ShowArray(int[] arr)
    {
        for (uint i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }
    */
}