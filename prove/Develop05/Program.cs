namespace GamificationProgram
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static int totalPoints = 0;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Select a choice from the menu:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateNewGoal()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create?");

            int goalType = Convert.ToInt32(Console.ReadLine());

            switch (goalType)
            {
                case 1:
                    Console.WriteLine("What is the name of your goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal:");
                    int points = Convert.ToInt32(Console.ReadLine());

                    Goal simpleGoal = new SimpleGoal(name, description, points);
                    goals.Add(simpleGoal);
                    totalPoints += points;

                    Console.WriteLine("Simple goal created successfully.");
                    break;
                case 2:
                    Console.WriteLine("What is a short description of the goal?");
                    string eternalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal?");
                    string eternalDescription = Console.ReadLine();
                    Console.WriteLine("Enter number of times to complete the goal:");
                    int timesToComplete = Convert.ToInt32(Console.ReadLine());

                    Goal eternalGoal = new EternalGoal(eternalName, eternalDescription, timesToComplete);
                    goals.Add(eternalGoal);

                    Console.WriteLine("Eternal goal created successfully.");
                    break;
                case 3:
                    Console.WriteLine("What is the name of your goal?");
                    string checklistName = Console.ReadLine();
                    Console.WriteLine("What is a short description of the goal?");
                    string checklistDescription = Console.ReadLine();
                    Console.WriteLine("Enter number of times to complete the goal:");
                    int checklistTimesToComplete = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter bonus points for completing the goal:");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());

                    Goal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistTimesToComplete, bonusPoints);
                    goals.Add(checklistGoal);

                    Console.WriteLine("Checklist goal created successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
            }
        }

        static void ListGoals()
        {
            Console.WriteLine("Goals:");

            foreach (Goal goal in goals)
            {
                Console.Write(goal.Name + " - ");

                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;
                    Console.Write(simpleGoal.Description + " - ");
                    Console.Write(simpleGoal.Points + " points");
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    Console.Write(eternalGoal.Description + " - ");
                    Console.Write(eternalGoal.TimesCompleted + "/" + eternalGoal.TimesToComplete + " times completed");
                }
                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    Console.Write(checklistGoal.Description + " - ");
                    Console.Write(checklistGoal.TimesCompleted + "/" + checklistGoal.TimesToComplete + " times completed");
                }

                Console.WriteLine();
            }
        }

        static void SaveGoals()
        {
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.GetType().Name);
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);

                    if (goal is SimpleGoal)
                    {
                        SimpleGoal simpleGoal = (SimpleGoal)goal;
                        writer.WriteLine(simpleGoal.Points);
                    }
                    else if (goal is EternalGoal)
                    {
                        EternalGoal eternalGoal = (EternalGoal)goal;
                        writer.WriteLine(eternalGoal.TimesToComplete);
                        writer.WriteLine(eternalGoal.TimesCompleted);
                    }
                    else if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        writer.WriteLine(checklistGoal.TimesToComplete);
                        writer.WriteLine(checklistGoal.TimesCompleted);
                        writer.WriteLine(checklistGoal.BonusPoints);
                    }
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }

        static void LoadGoals()
{
    Console.WriteLine("Enter file name:");
    string fileName = Console.ReadLine();

    if (File.Exists(fileName))
    {
        goals.Clear();
        totalPoints = 0;

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string name = reader.ReadLine();
                string description = reader.ReadLine();

                switch (goalType)
                {
                    case "SimpleGoal":
                        int points = Convert.ToInt32(reader.ReadLine());
                        Goal simpleGoal = new SimpleGoal(name, description, points);
                        goals.Add(simpleGoal);
                        totalPoints += points;
                        break;
                    case "EternalGoal":
                        int timesToComplete = Convert.ToInt32(reader.ReadLine());
                        int timesCompleted = Convert.ToInt32(reader.ReadLine());
                        EternalGoal eternalGoal = new EternalGoal(name, description, timesToComplete);
                        eternalGoal.TimesCompleted = timesCompleted;
                        goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        int checklistTimesToComplete = Convert.ToInt32(reader.ReadLine());
                        int checklistTimesCompleted = Convert.ToInt32(reader.ReadLine());
                        int bonusPoints = Convert.ToInt32(reader.ReadLine());
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, checklistTimesToComplete, bonusPoints);
                        checklistGoal.TimesCompleted = checklistTimesCompleted;
                        goals.Add(checklistGoal);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type in file.");
                        break;
                }
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    else
    {
        Console.WriteLine("File does not exist.");
    }
}

        static void RecordEvent()
        {
            Console.WriteLine("Select event:");
            Console.WriteLine("1. Give a Talk");
            Console.WriteLine("2. Study the Scriptures");
            Console.WriteLine("3. Attend the Temple");

            int eventChoice = Convert.ToInt32(Console.ReadLine());

            switch (eventChoice)
            {
                case 1:
                    Console.WriteLine("Congratulations! You gave a talk.");
                    totalPoints += 100;
                    break;
                case 2:
                    Console.WriteLine("Congratulations! You studied the scriptures.");
                    totalPoints += 50;
                    break;
                case 3:
                    Console.WriteLine("Congratulations! You attended the temple.");
                    totalPoints += 150;
                    break;
                default:
                    Console.WriteLine("Invalid event choice. Please try again.");
                    break;
            }
        }
    }

}   