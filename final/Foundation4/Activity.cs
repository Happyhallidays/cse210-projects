using System;
using System.Collections.Generic;

abstract class Activity
{
    protected DateTime date;
    protected int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // in mph
    public abstract double GetPace();     // in min/mile

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({lengthMinutes} min) - " +
               $"Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}