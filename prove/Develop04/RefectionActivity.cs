public class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>();
    private List<FlaggedString> _questions = new List<FlaggedString>();

    public ReflectionActivity(string name, string description, int seconds)
        : base(name, description, seconds) { }

    public void RunActivity()
    {
        SetPromptsAndQuestions();
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine(GetPromptString(_prompts));
            Console.WriteLine(GetPromptString(_questions));
            Thread.Sleep(5000);
        }

        DisplayEnding();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Think of a time you showed courage."),
            new FlaggedString("Think of a time you helped someone.")
        };

        _questions = new List<FlaggedString>
        {
            new FlaggedString("Why was this experience meaningful to you?"),
            new FlaggedString("What did you learn from this experience?")
        };
    }

    private void ResetPromptsUsage()
    {
        foreach (var item in _prompts)
            item.Used = false;
        foreach (var item in _questions)
            item.Used = false;
    }
}