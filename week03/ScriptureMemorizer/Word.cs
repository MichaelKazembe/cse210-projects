public class Word
{
    private string _text;
    private bool _isHidden;

    // Create a word with text
    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide(){
        _isHidden = true;
    }

    // Show the word
    public void Show(){
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display text of the word
    public string GetDisplayText(){
        if (_isHidden){
            string result = new string('_', _text.Length); // Create a string with the same length as the word
            return result;
        }
        else{
            return _text;
        }
    }
}
