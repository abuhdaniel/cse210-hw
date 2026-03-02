using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter your second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = AddNumbers(num1, num2);

        Console.WriteLine($"The sum of the two numbers is {result}");
    }

    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
}