class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "Countryland");
        Address address2 = new Address("456 Elm St", "Townsville", "Countryland");
        Address address3 = new Address("789 Oak St", "Villageton", "Countryland");

        Lecture lecture = new Lecture("Tech Talk", "Exciting tech innovations", DateTime.Now, "10:00 AM", address1, "Duane Richards", 50);
        Reception reception = new Reception("Networking Event", "Connect with professionals", DateTime.Now, "2:00 PM", address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities", DateTime.Now, "4:00 PM", address3, "Sunny skies");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("\nReception Details:");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("\nOutdoor Gathering Details:");
        Console.WriteLine(gathering.GetFullDetails());
    }
}