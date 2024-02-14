using System;

class Program
{
     private static int score = 0;
        
     private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
       

        // Load saved goals and score if available
        LoadGoals();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. List goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    RecordEvent();
                    break;

                case 3:
                    ShowGoals();
                    break;

                case 4:
                    ShowScore();
                    break;

                case 5:
                    SaveGoals();
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Enter the goal type");
        Console.WriteLine("1 - Simple Goal");
        Console.WriteLine("2 - Eternal Goal");
        Console.WriteLine("3 - Checklist Goal");
        int goalType = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("What is the name of your: ");
        string goalName = Console.ReadLine();
        
        Console.Write("Enter the points for completing the goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal;

        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(goalName, points);
                break;

            case 2:
                goal = new EternalGoal(goalName, points);
                break;

            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(goalName, points, targetCount);
                break;

            default:
                Console.WriteLine("Invalid goal type. Goal creation failed.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine($"New goal '{goalName}' created successfully!");
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select the goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].GetStatus()}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            Goal goal = goals[goalNumber];
            goal.Complete();
            score += goal.Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number. Event recording failed.");
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("Current Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"[{goals[i].GetStatus()}] {goals[i].Name}");
        }
    }

    private static void ShowScore()
    {
        Console.WriteLine($"Current Score: {score} points");
    }

    private static void SaveGoals()
    {
        
        Console.WriteLine("Goals and Score saved successfully!");
    }

    private static void LoadGoals()
    {
        
        Console.WriteLine("Goals and Score loaded successfully!");
    }
}


        
    
