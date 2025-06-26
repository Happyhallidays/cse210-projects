public class CheckList : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int Bonus { get; set; }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
        }
    }

    public override bool IsComplete()
    {
        return CurrentCount >= TargetCount;
    }

    public override string GetDetails()
    {
        return $"{Name} ({Description}) - Completed {CurrentCount}/{TargetCount} times";
    }
}