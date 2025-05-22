using System;
using System.ComponentModel.Design;

class Program
{
    private static string ObtainFileName(string prompt)
    {
        Console.WriteLine(prompt);
        string fileName = Console.ReadLine();
        return fileName;
    }

    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        JournalQuestion journalQuestions = new JournalQuestion();

        Menu menu = new Menu("Journal Program", "Write, Display, Save, and load your journal");
        menu.DisplayTitle();
        string fileName = "";
        int response = 0;
        while (response != 5)
        {
            response = menu.ProcessMenu();

            switch (response)
            {
                case 1:
                    JournalEntry journalEntry = new JournalEntry();
                    string question = journalEntry.NextQuestion();
                    journalQuestions.CreateEntry(question);

                    journalEntry.Display();

                    newJournal.AddEntry(journalEntry);
                    break;

                case 2:
                    newJournal.Display();
                    break;
                
                case 3:
                    fileName = ObtainFileName("File Name from which to read Journal: ");
                    newJournal.ReadFromFile(fileName);
                    break;
                
                case 4:
                    fileName = ObtainFileName("File Name to which to write Journal: ");
                    newJournal.WriteToFile(fileName);
                    break;
                
                case 5:
                    break;
                default:
                    Console.WriteLine("Error, please input valid value.");
                    break;
                
            }
        }
    }
}