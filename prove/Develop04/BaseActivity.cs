public class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public BaseActivity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _duration = seconds;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name}.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplayEnding()
    {
        Console.WriteLine("Well done!");
    }

    public void RunCountDown(string message, int seconds)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void DisplaySpinner(string message, int seconds)
    {
        Console.Write(message);
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }

    public void ObtainDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public string GetPromptString(List<FlaggedString> items)
    {
        var unused = items.Where(p => !p.Used).ToList();
        if (!unused.Any()) return "";
        var rand = new Random();
        var item = unused[rand.Next(unused.Count)];
        item.Used = true;
        return item.Text;
    }
}