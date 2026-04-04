using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it successful?"
    };

    private Random _rand = new Random();

    public ReflectingActivity()
        : base("Reflecting",
        "This activity helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        ShowSpinner(5);

        int time = 0;
        while (time < _duration)
        {
            Console.WriteLine("\n" + GetRandomQuestion());
            ShowSpinner(4);
            time += 4;
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }
}