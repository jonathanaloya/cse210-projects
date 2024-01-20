public class PromptGenerator
{
    public string[] prompts;
    public Random random;

    public PromptGenerator(string[] prompts)
    {
        this.prompts = prompts;
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Length)];
    }
}