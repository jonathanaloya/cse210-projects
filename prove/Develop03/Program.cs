public class Program
{
   public static void Main()
   {
       var scriptures = new List<Scripture>()
       {
           new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
           new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
           new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
           new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."),
           new Scripture(new Reference("Matthew", 6, 33), "But seek first his kingdom and his righteousness, and all these things will be given to you as well.")
       };

       while (true)
       {
           Console.Clear();
           var scripture = scriptures[new Random().Next(scriptures.Count)];
           Console.WriteLine(scripture.GetDisplayText());
           Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
           string input = Console.ReadLine();

           if (input.ToLower() == "quit" || scriptures.All(s => s.IsCompletelyHidden()))
               break;

           scripture.HideRandomWords(2);
       }
   }
}