public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        IsComplete();
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string goalType = nameof(EternalGoal);
        return $"{goalType}~|~{_shortName}~|~{_description}~|~{_points}";
    }
}