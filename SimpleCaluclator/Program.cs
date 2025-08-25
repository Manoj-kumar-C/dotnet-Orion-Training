// See https://aka.ms/new-console-template for more information



using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the 1st Num :");

        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 2nd Num:");

        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Operator (+, -, *, /):");
        string op = Console.ReadLine();


        switch (op)
        {
            case "+":
                Console.WriteLine(num1 + num2);
                break;
            case "-":
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                if(num2 != 0)
                {
                    Console.WriteLine(num1 / num2);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;

        }

    }
}
