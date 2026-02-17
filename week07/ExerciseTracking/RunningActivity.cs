using System.ComponentModel.DataAnnotations;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _lengthInMinutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _lengthInMinutes / _distance;
        return pace;
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}