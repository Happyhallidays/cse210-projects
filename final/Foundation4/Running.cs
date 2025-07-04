class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / lengthMinutes) * 60;

    public override double GetPace() => lengthMinutes / distance;
}
