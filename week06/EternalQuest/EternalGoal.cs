public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return GetPoints(); // never completes
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetSaveString()
    {
        return $"Eternal|{GetName()}";
    }
}