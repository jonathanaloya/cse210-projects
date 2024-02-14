public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount)
    {
        Name = name;
        Points = points;
        TargetCount = targetCount;
        currentCount = 0;
    }

    public override void Complete()
    {
        currentCount++;

        Console.WriteLine($"{Name} activity completed ({currentCount}/{TargetCount}). You gained {Points} points!");

        if (currentCount == TargetCount)
        {
            int bonusPoints = 500;
            Console.WriteLine($"Congratulations! You achieved the desired amount. Bonus: {bonusPoints} points!");
            Points += bonusPoints;
        }
    }

    public override string GetStatus()
    {
        return $"Completed {currentCount}/{TargetCount} times";
    }
}
