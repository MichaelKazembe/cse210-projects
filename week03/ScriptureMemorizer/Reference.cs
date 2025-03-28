public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Create a reference with a book, chapter, and verse
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Single verse
    }

    // Create a reference with a book, chapter, verse, and end verse
    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Get the display text of the reference
    public string GetDisplayText(){
        if (_verse == _endVerse){
            return $"{_book} {_chapter}:{_verse}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
