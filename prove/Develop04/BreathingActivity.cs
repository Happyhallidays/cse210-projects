public class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description, int seconds) : base(name, description, seconds) {}

    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        while (!HasTimerExpired())
        {
            Console.Write("Breathe in...");
            RunSpinner(3);
            Console.WriteLine();
            RunCountDown("", 3);

            Console.Write("Now breathe out...");
            RunSpinner(3);
            Console.WriteLine();
            RunCountDown("", 3);

            Console.WriteLine();
        }

        DisplayEnding();
    }

    private void RunSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }
}

