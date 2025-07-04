class Program
{
    static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 7, 1), 30, 3.0),
            new Cycling(new DateTime(2025, 7, 2), 45, 15.0),
            new Swimming(new DateTime(2025, 7, 3), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}