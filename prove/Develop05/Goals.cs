public class Goals
{
    private List<Goal> _goalList = new List<Goal>();
    private int _score = 0;

    public void CreateGoalMenu()
    {
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string input = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                _goalList.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goalList.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target completion count: ");
                int max = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goalList.Add(new ChecklistGoal(name, description, points, false, 0, max, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    public void ListGoals()
    {
        if (_goalList.Count == 0)
        {
            Console.WriteLine("No goals added.");
            return;
        }

        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalList[i].ListGoal()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter the number of the goal you completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goalList.Count)
        {
            int earned = _goalList[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"🏆 You earned {earned} points! Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"🎯 Current Score: {_score}");
    }
}