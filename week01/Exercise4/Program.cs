using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        string userInput = "";

        Console.WriteLine("Enter names (type 'done' when finished):");

        while (userInput.ToLower() != "done")
        {
            Console.Write("Enter a name: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "done")
            {
                names.Add(userInput);
            }
        }

        Console.WriteLine("\nHere are the names you entered:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}