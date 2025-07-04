class Swimming : Activity
{
    private int laps; // laps of 50 meters

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Convert meters to miles: laps * 50 m * 0.000621371 miles/meter
        return laps * 50 * 0.000621371;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / GetDistance();
    }
}
