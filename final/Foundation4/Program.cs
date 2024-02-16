public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        activities.Add(new RunningActivity(DateTime.Now, 30, 3.0));
        activities.Add(new CyclingActivity(DateTime.Now, 45, 20.0));
        activities.Add(new SwimmingActivity(DateTime.Now, 60, 10));

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}