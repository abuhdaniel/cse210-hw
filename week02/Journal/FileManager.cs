using System;
using System.Collections.Generic;
using System.IO;

public class FileManager
{
    public void SaveJournal(string filename, Journal journal)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.GetEntries())
            {
                output.WriteLine(entry.ToFileFormat());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public Journal LoadJournal(string filename)
    {
        Journal journal = new Journal();
        List<Entry> entries = new List<Entry>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            entries.Add(Entry.FromFileFormat(line));
        }

        journal.SetEntries(entries);

        Console.WriteLine("Journal loaded successfully.");

        return journal;
    }
}