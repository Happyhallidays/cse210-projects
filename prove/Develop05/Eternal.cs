public class EternalGoal : Goal
{
    private int numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool isComplete = false, int completions = 0)
        : base(name, description, points, isComplete)
    {
        numberOfCompletions = completions;
    }

    public override int RecordEvent()
    {
        numberOfCompletions++;
        Console.WriteLine("🔁 Eternal goal recorded!");
        return Points;
    }

    public override string GetGoalType() => "Eternal";

    public override string ListGoal() =>
        $"{Name} (Eternal) — {Description} — Completed {numberOfCompletions} times";

    public override string ToString() => $"{Name}|{Description}|{Points}|{numberOfCompletions}";
}