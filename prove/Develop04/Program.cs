using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Menu!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Start reflecting activity");
        Console.WriteLine("2. Start breathing activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                break;
            case 2:
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;
            case 3:
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
        }   }
        
}