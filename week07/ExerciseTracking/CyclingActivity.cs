public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed/60) * _lengthInMinutes;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }

}