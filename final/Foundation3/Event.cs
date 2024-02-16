public class Event
{
    public string Title { get; set; }
    private string Description { get; set; }
    public DateTime Date { get; set; }
    private TimeSpan Time { get; set; }
    private string Address { get; set; }

    // Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, string address )
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    // Method to generate standard details message
    public string GenerateStandardDetailsMessage()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString()}\nAddress: {Address.ToString()}";
    }
}
