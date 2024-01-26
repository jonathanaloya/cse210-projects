public class Reference
{
    private string _book;
    private int _chapter;
    private int? _verse, _endVerse; 

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse; 
        this._endVerse = null; 
     }

     // Constructor for range of verses
     public Reference(string book, int chapter, int startVerse, int endVerse)
     {
         this._book = book; 
         this._chapter = chapter; 
         this._verse= startVerse; 
         this._endVerse= endVerse; 
      }

      // Method to get display text of reference
      public string GetDisplayText()
      {
          return $"{_book} {_chapter}:{_verse}" + (_endVerse.HasValue ? $"-{_endVerse}" : "");
      }
}