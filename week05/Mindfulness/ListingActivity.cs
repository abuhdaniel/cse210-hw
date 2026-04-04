using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private List<string> _items = new List<string>();
    private Random _rand = new Random();

    public ListingActivity()
        : base("Listing",
        "This activity helps you list positive things in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("Start listing in:");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}