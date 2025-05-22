class JournalEntry
{
    //something missing up here
    private string _date;
    private string _entryQuestion;
    private string _journalEntry;

    public JournalEntry()
    {
        _date = "";
        _entryQuestion = "";
        _journalEntry = "";
    }

    public JournalEntry(string date, string entryQuestion, string journalEntry)
    {
        _date = date;
        _entryQuestion = entryQuestion;
        _journalEntry = journalEntry;
   }

    public void Display()
    {
        Console.WriteLine($"{_date}:");
        Console.WriteLine($"{_entryQuestion}");
        Console.WriteLine(_journalEntry);
    }

    public string CreateFileSystemString()
    {
        string outputString = "";

        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        return outputString;
    }

    public void CreateEntry(string _entryQuestion)
    {
        Console.WriteLine(_entryQuestion);
        Console.Write(">");
        string journalEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;

        this._date = theCurrentTime.ToShortDateString();
        this._entryQuestion = _entryQuestion;
        this._journalEntry = journalEntry;
    }
}