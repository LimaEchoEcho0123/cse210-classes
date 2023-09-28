public class Journal{
    // public List<Entry> entries;
    public List<Entry> entries = new List<Entry>();
    
    public string _promptText;

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
        Console.WriteLine();
    }

    public void DisplayAll()
    {
        foreach(Entry entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveFile(string file)
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
          foreach(Entry entry in entries)
          {
            outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
          }
        }
    }

    public void LoadFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            Console.WriteLine($"{_date}, {_promptText}, {_entryText}");
        }

    }
    public void Quit()
    {
        
    }
}