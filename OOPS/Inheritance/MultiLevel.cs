using System;

interface IFly
{
    void Fly();
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food");
    }
}

class Bird : Animal, IFly   // Hybrid: class + interface
{
    public void Fly()
    {
        Console.WriteLine("Bird flies in the sky");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.Eat();  // From Animal
        bird.Fly();  // From IFly
    }
}
