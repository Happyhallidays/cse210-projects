public class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;

    public ListingActivity(string name, string description, int seconds)
        : base(name, description, seconds)
    {
        _prompts = new List<FlaggedString>();
        SetPrompts();
    }

    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        Console.WriteLine("List as many responses as you can:");
        Console.WriteLine(GetPromptString(_prompts));

        int count = 0;
        while (!HasTimerExpired())
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayEnding();
    }

    private void SetPrompts()
    {
        _prompts.Add(new FlaggedString("List things you are grateful for"));
        _prompts.Add(new FlaggedString("List people you admire"));
    }

    private void ResetPromptsUsage()
    {
        foreach (var p in _prompts)
            p.Used = false;
    }
}