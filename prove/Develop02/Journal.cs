class Journal
{
    public void WriteToFile(string filename)​

    {​

        using (StreamWriter outputFile = new StreamWriter(filename))​

        {          ​

            foreach(JournalEntry entry in entries)​

            {​

                outputFile.WriteLine(entry.CreateStringForFileSystem());​

            }​

        }​

    }

    public void ReadFromFile(string filename)​

    {​

        string[] lines = System.IO.File.ReadAllLines(filename);​

​
        foreach (string line in lines)​

        {​

            string[] parts = line.Split("#");​

​
            string date = parts[0];​

            string question = parts[1];​

            string entryText = parts[2];​

​
            JournalEntry entry = new JournalEntry(date, question, entryText);  ​

            this.AddEntry(entry);​

        }​

    }​
}