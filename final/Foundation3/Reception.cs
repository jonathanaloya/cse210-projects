public class Reception : Event
{
    private string RSVP { get; set; }

    // Constructor
    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string rsvp)
        : base(title, description, date, time, address)
    {
        RSVP = rsvp;
    }

    // Method to generate full details message
    public string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardDetailsMessage()}\nRSVP: {RSVP}";
    }
}