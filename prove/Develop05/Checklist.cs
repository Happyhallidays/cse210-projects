public class ChecklistGoal : Goal
{
    private int currentCount;
    private int maxGoals;
    private int bonusPoints;
    private bool bonusAwarded;

    public ChecklistGoal(string name, string description, int points, bool isComplete, int completions, int max, int bonus)
        : base(name, description, points, isComplete)
    {
        currentCount = completions;
        maxGoals = max;
        bonusPoints = bonus;
        bonusAwarded = false;
    }

    public override int RecordEvent()
    {
        if (currentCount < maxGoals)
        {
            currentCount++;
            Console.WriteLine($"📝 Checklist goal progress: {currentCount}/{maxGoals}");

            if (currentCount >= maxGoals && !bonusAwarded)
            {
                bonusAwarded = true;
                IsComplete = true;
                Console.WriteLine($"🎉 Goal completed! Bonus: {bonusPoints} points");
                return Points + bonusPoints;
            }

            return Points;
        }
        Console.WriteLine("Goal already fully completed.");
        return 0;
    }

    public override string GetGoalType() => "Checklist";

    public override string ListGoal() =>
        $"{Name} (Checklist) — {Description} — {currentCount}/{maxGoals} completed";

    public override string ToString() => $"{Name}|{Description}|{Points}|{currentCount}|{maxGoals}|{bonusPoints}";
}