using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance()} km, " +
               $"Speed: {GetSpeed()} km/hour, " +
               $"Pace: {GetPace()} min per km";
    }
}
