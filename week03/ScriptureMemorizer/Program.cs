using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// - Program selects scriptures randomly from a list
// - Only visible words are hidden each round
// - Added difficulty levels (easy/medium/hard)

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Doctrine and Covenants 56:16-17
        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 56, 16, 17),
            "Wo unto you rich men that will not give your substance to the poor for your riches will canker your souls and this shall be your lamentation in the day of visitation and of judgment and of indignation the harvest is past the summer is ended and my soul is not saved"
        ));

        // Doctrine and Covenants 19:4-7
        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 19, 4, 7),
            "And surely every man must repent or suffer for I God am endless wherefore I revoke not the judgments which I shall pass but woes shall go forth weeping wailing and gnashing of teeth yea to those who are found on my left hand nevertheless it is not written that there shall be no end to this torment but it is written endless torment"
        ));

        // Doctrine and Covenants 104:78
        scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 104, 78),
            "And again verily I say unto you concerning your debts behold it is my will that you shall pay all your debts"
        ));

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        Console.Write("Choose difficulty (easy/medium/hard): ");
        string difficulty = Console.ReadLine().ToLower();

        int wordsToHide = 3;
        if (difficulty == "easy") wordsToHide = 2;
        else if (difficulty == "hard") wordsToHide = 5;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter or type 'quit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(wordsToHide);
        }
    }
}