public class Resume
{
    public string _personName;
    public List<Job>_jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName}");
    }
}
