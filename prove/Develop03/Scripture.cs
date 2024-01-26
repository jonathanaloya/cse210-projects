public class Scripture
{
   private Reference  reference ;
   private List<Word> words ;

   // Constructor for scripture with reference and text as parameters.
   public Scripture(Reference  reference , string text)
   {
       this.reference  = reference ;
       words  = new List<Word>();
       foreach (var word in text.Split(' '))
       {
           words .Add(new Word(word));
       }
   }

   // Method to hide random words in scripture.
   public void HideRandomWords(int numberToHide)
   {
       var rand= new Random();
       for (int i=0 ; i<numberToHide ; i++)
       {
           var index=rand.Next(words.Count);
           words[index].Hide();
       }
   }

// Method to get display text of scripture.
    public string GetDisplayText()
    {
        return $"{reference.GetDisplayText()} - {string.Join(" ", words.Select(w => w.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }

}