using System;



class Car
{
    public string color;
    public string model;
    // This is a constructor // Parameters are passed to the constructor
    public Car(string carColor, string carModel)
    {
        color = carColor;
        model = carModel;
    }

    // This is a method
    public void DisplayDetails()
    {
        Console.WriteLine("Car Model: " + model);
        Console.WriteLine("Car Color: " + color);
    }

    // Destructor
    ~Car()
    {
        Console.WriteLine("Destructor called for " + model);
    }

}


class Construc
{
    public static void Main(string[] args)
    {
        Car myCar = new Car("Red", "Audi");


        myCar.DisplayDetails();
    }
}