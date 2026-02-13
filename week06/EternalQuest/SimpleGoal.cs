public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        string goalType = nameof(SimpleGoal);
        return $"{goalType}~|~{_shortName}~|~{_description}~|~{_points}~|~{_isComplete}";
    }
}