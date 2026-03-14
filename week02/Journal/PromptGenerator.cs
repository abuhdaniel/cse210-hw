using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What is one new thing I learned today?",
        "What moment today made me feel grateful?",
        "What challenge did I face today and how did I handle it?",
        "What is one thing I accomplished today that I am proud of?",
        "What is something small that made today better?",
        "What goal would I like to focus on tomorrow?",
        "What is one lesson today taught me?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}