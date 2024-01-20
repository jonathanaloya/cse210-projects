using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator(new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        });

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case 5:
                    return;
            }
        }
    }
}
