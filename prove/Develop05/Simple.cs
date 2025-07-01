public class Simple : Goal
{
    private bool _isComplete = false;

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"{Name} ({Description}) - {(_isComplete ? "Completed" : "Not Completed")}";
    }

    public Simple(string name, string description) : base(name, description, 100)
{
    _isComplete = false;
}
}