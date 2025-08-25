// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter no of Sub: ");

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;
        int avg = 0;

        for (int i=0; i<n; i++)
        {
            Console.WriteLine("Enter Sub " + (i + 1));
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        avg = sum / n;


        if(avg > 89) { 
                Console.WriteLine("Grade A : ");
        }else if(avg > 79)
        {
            Console.Write("B");
        }
        else if (avg > 69)
        {
            Console.Write("C");
        }
        else if (avg > 59)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("E");
        }

    }
}