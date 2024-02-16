public class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    // Constructor
    public Lecture(string title, string description, DateTime date, TimeSpan time,string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    // Method to generate full details message
    public string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardDetailsMessage()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}