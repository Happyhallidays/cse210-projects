public class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        Menu menu = new Menu();

        bool running = true;
        while (running)
        {
            menu.Show();
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // Logic to create a new goal
                    break;
                case "2":
                    goals.ListGoals();
                    break;
                case "3":
                    // Logic to record an event
                    break;
                case "4":
                    running = false;
                    break;
            }
        }
    }
}