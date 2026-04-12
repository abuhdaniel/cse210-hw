using System;

class Program
{
    static void Main()
    {
        // EXCEEDING REQUIREMENTS:
        // - Added level system (level increases every 1000 points)
        // - Level-up notification system
        // - Fully implemented save/load with complete data tracking

        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                    string type = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Description: ");
                    string desc = Console.ReadLine();

                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1")
                        manager.AddGoal(new SimpleGoal(name, desc, points));
                    else if (type == "2")
                        manager.AddGoal(new EternalGoal(name, desc, points));
                    else if (type == "3")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());

                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());

                        manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Select goal #: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "4":
                    manager.DisplayScore();
                    break;

                case "5":
                    manager.Save("goals.txt");
                    Console.WriteLine("Saved!");
                    break;

                case "6":
                    manager.Load("goals.txt");
                    Console.WriteLine("Loaded!");
                    break;

                case "7":
                    running = false;
                    break;
            }
        }
    }
}