public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points, isComplete)
    {
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine("✅ Simple goal completed!");
            return Points;
        }
        Console.WriteLine("Goal already completed.");
        return 0;
    }

    public override string GetGoalType() => "Simple";

    public override string ListGoal() =>
        $"{Name} (Simple) — {Description} - {(IsComplete ? "Completed" : "Not Completed")}";

    public override string ToString() => $"{Name}|{Description}|{Points}|{IsComplete}";
}
