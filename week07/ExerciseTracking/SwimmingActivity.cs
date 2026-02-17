public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(double length, double laps) : base(length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 *0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / _lengthInMinutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _lengthInMinutes / GetDistance();
        return pace;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

}