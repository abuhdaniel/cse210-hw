using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"Your favorite number is {number}.");
        Console.WriteLine($"Did you know that {number} squared is {number * number}?");
    }
}