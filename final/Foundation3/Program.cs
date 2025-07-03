class Program
{
    static void Main()
    {
        Address addr1 = new Address("100 Main St", "New York", "NY", "USA");
        Lecture lecture = new Lecture("Tech Talk", "Learn about AI", new DateTime(2025, 7, 15, 19, 0, 0), addr1, "Dr. Smith", 100);

        Address addr2 = new Address("500 Park Ave", "Los Angeles", "CA", "USA");
        Reception reception = new Reception("Company Party", "End of year celebration", new DateTime(2025, 12, 5, 18, 30, 0), addr2, "rsvp@company.com");

        Address addr3 = new Address("Central Park", "New York", "NY", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Festival", "Outdoor fun and music", new DateTime(2025, 8, 10, 12, 0, 0), addr3, "Sunny, 75F");

        Event[] events = { lecture, reception, outdoor };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}