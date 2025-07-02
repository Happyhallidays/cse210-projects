public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int points, bool isComplete = false)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = isComplete;
    }

    public abstract int RecordEvent();
    public abstract string GetGoalType();
    public abstract string ToString();
    public abstract string ListGoal();
}