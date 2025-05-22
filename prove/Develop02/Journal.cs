// class Journal
// {
//     public void WriteToFile(string filename)​

//     {​

//         using (StreamWriter outputFile = new StreamWriter(filename))​

//         {          ​

//             foreach(JournalEntry entry in entries)​

//             {​

//                 outputFile.WriteLine(entry.CreateStringForFileSystem());​

//             }​

//         }​

//     }

//     public void ReadFromFile(string filename)​

//     {​

//         string[] lines = System.IO.File.ReadAllLines(filename);​

// ​
//         foreach (string line in lines)​

//         {​

//             string[] parts = line.Split("#");​

// ​
//             string date = parts[0];​

//             string question = parts[1];​

//             string entryText = parts[2];​

// ​
//             JournalEntry entry = new JournalEntry(date, question, entryText);  ​

//             this.AddEntry(entry);​

//         }​

//     }​
// }

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void WriteEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry journalentry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToString("yyyy-MM-dd")
        };

        _entries.Add(journalentry);
        Console.WriteLine("Entry recorded.");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"\nDate: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                JournalEntry journalentry = new JournalEntry
                {
                    Date = parts[0],
                    Prompt = parts[1],
                    Response = parts[2]
                };
                _entries.Add(journalentry);
            }
        }
        Console.WriteLine("Journal loaded.");
    }
}