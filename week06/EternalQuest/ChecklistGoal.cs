public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }


    public override int RecordEvent()
    {
        _amountCompleted ++;
        IsComplete();
        if (IsComplete() == true)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $" [ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        else
        {
            return $" [X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        string goalType = nameof(ChecklistGoal);
        return $"{goalType}~|~{_shortName}~|~{_description}~|~{_points}~|~{_bonus}~|~{_target}~|~{_amountCompleted}";
    }
}