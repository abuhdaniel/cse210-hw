using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🔥 LEVEL UP! You are now Level {_level}!");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        Console.WriteLine($"Level: {_level}");
    }

    public void Save(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetSaveString());
            }
        }
    }

    public void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                ChecklistGoal g = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                );

                int count = int.Parse(parts[4]);

                for (int j = 0; j < count; j++)
                {
                    g.RecordEvent();
                }

                _goals.Add(g);
            }
        }
    }
}