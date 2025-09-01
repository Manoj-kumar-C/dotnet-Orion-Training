using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10, b = 0;
            int result = a / b;   // will throw DivideByZeroException
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            Console.WriteLine("Details: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block always executes.");
        }
    }
}
