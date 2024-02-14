public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void Complete()
    {
        // Simple activities are marked as complete instantly without any conditions
        Console.WriteLine($"{Name} activity completed. You gained {Points} points!");
    }

    public override string GetStatus()
    {
        return "Complete";
    }
}

