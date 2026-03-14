using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void SetEntries(List<Entry> entries)
    {
        _entries = entries;
    }
}