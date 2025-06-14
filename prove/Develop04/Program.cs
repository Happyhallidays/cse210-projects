class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Breathing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new ListingActivity("Listing", "List as many as you can in the time limit.", 0).RunActivity();
                    break;
                case "2":
                    new ReflectionActivity("Reflection", "Reflect on meaningful experiences.", 0).RunActivity();
                    break;
                case "3":
                    new BreathingActivity("Breathing", "Follow the breathing prompts.", 0).RunActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
