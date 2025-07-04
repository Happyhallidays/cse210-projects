class Cycling : Activity
{
    private double speed; // mph

    public Cycling(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => speed * lengthMinutes / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}