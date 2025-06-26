public class Eternal : Goal
{
    public override void RecordEvent()
    {
        // Never marked complete
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"{Name} ({Description}) - Eternal goal (never completed)";
    }
}