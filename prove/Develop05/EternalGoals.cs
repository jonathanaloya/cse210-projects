public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void Complete()
    {
        Console.WriteLine($"{Name} activity recorded. You gained {Points} points!");
    }

    public override string GetStatus()
    {
        return "Recorded";
    }
}
