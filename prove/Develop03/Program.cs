using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = ScriptureBank.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            scripture.ShowScripture();

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit" || !scripture.HideSomeWords())
                break;
        }

        Console.WriteLine("Program ended.");
    }
}
