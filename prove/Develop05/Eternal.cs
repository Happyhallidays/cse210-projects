public class Eternal : Goal
{
    public Eternal(string name, string description)
        : base(name, description, 100)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Eternal goal progress recorded.");
        // No change in state; points granted each time externally
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never "complete"
    }

    public override string GetDetails()
    {
        return $"{_name} (Eternal) — {_description}";
    }
}