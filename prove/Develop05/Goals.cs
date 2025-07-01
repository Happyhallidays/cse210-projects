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

            bool wasComplete = goal.IsComplete();
            goal.RecordEvent();

            bool nowComplete = goal.IsComplete();

            if (!wasComplete && nowComplete)
            {
                _score += goal.Points;
                Console.WriteLine("✅ Goal completed! +100 points");
            }
            else
            {
                Console.WriteLine("Goal updated, but not yet complete.");
            }
        if (!goal.WasRewarded() && nowComplete)
            {
                _score += goal.Points;
                goal.MarkRewarded();
                Console.WriteLine("✅ Goal completed! +100 points");
            }


            Console.WriteLine($"You earned points! Current score: {_score}");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
}