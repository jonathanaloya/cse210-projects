public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Prompt},{entry.Response},{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string[] fields = reader.ReadLine().Split(',');
                string prompt = fields[0];
                string response = fields[1];
                DateTime date = DateTime.Parse(fields[2]);
                entries.Add(new Entry(prompt, response) { Date = date });
            }
        }
    }
}