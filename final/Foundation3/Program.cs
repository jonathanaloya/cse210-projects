class Program
{
    static void Main(string[] args)
    {
        // Create event instances
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming", DateTime.Now, TimeSpan.FromHours(2), new Address("123 Main St", "City", "State", "12345"), "John Doe", 50);
        Reception reception = new Reception("Networking Event", "Meet professionals in your industry", DateTime.Now, TimeSpan.FromHours(3), new Address("456 Elm St", "City", "State", "12345"), "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy a day in the park", DateTime.Now, TimeSpan.FromHours(4), new Address("789 Oak St", "City", "State", "12345"), "Sunny");

        // Generate marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GenerateStandardDetailsMessage());
        Console.WriteLine(reception.GenerateStandardDetailsMessage());
        Console.WriteLine(gathering.GenerateStandardDetailsMessage());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GenerateFullDetailsMessage());
        Console.WriteLine(reception.GenerateFullDetailsMessage());
        Console.WriteLine(gathering.GenerateFullDetailsMessage());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine($"Lecture: {lecture.Title}, Date: {lecture.Date.ToShortDateString()}");
        Console.WriteLine($"Reception: {reception.Title}, Date: {reception.Date.ToShortDateString()}");
        Console.WriteLine($"Outdoor Gathering: {gathering.Title}, Date: {gathering.Date.ToShortDateString()}");

        Console.ReadLine();
    }
}
