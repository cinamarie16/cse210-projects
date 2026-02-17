public abstract class Activity
{
    protected DateOnly _date;
    protected double _lengthInMinutes;

    public Activity(double length)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _lengthInMinutes = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetActivityType();

    public string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        return $"{formattedDate} {GetActivityType()} ({_lengthInMinutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}