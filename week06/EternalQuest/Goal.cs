public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetName() => _name;
    public int GetPoints() => _points;

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string GetSaveString();
}