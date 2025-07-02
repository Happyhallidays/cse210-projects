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
                    goals.CreateGoalMenu();
                    break;
                case "2":
                    goals.ListGoals();
                    break;
                case "3":
                    goals.RecordEvent();
                    break;
                case "4":
                    goals.ShowScore();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}