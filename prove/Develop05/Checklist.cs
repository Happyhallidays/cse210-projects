public class CheckList : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;
    private bool _bonusAwarded;

    public CheckList(string name, string description, int targetCount, int bonus)
        : base(name, description, 100)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
        _bonusAwarded = false;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Checklist progress: {_currentCount}/{_targetCount}");
        }
        else
        {
            Console.WriteLine("Checklist goal already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public bool BonusEligible()
    {
        return IsComplete() && !_bonusAwarded;
    }

    public void MarkBonusAwarded()
    {
        _bonusAwarded = true;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetDetails()
    {
        return $"{_name} (Checklist) — {_description} — {_currentCount}/{_targetCount} completed";
    }
}