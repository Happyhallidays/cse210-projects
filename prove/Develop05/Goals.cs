public class Goals
{
    private List<Goal> _goalList = new List<Goal>();

    private int _score = 0;
    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void ListGoals()
    {
        foreach (var goal in _goalList)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void RecordEvent(int index)
{
    if (index >= 0 && index < _goalList.Count)
    {
        Goal goal = _goalList[index];
        goal.RecordEvent();

        if (goal is CheckList checklist)
        {
            _score += checklist.Points;
            if (checklist.IsComplete())
            {
                _score += checklist.Bonus;
            }
        }
        else if (goal is Simple simple && !simple.IsComplete())
        {
            _score += simple.Points;
        }
        else if (goal is Eternal eternal)
        {
            _score += eternal.Points;
        }

        Console.WriteLine($"You earned points! Current score: {_score}");
    }
}
}