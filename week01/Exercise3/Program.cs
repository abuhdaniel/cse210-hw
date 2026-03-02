using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Console.WriteLine($"The sum of numbers from 1 to {number} is {sum}");
    }
}