using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    // Create a scripture with a reference and text
    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words
        foreach (var word in text.Split(' ')){
            Word newWord = new Word(word); // Create a new Word object
            _words.Add(newWord); // Add the Word object to the list
        }
    }

    // Hide a random number of words
    public void HideRandomWords(int numberToHide){
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count); // Get a random index
            _words[index].Hide(); // Hide the word
        }
    }

    // Get the display text of the scripture
    public string GetDisplayText(){
        string displayText = "";
        foreach (var word in _words){
            displayText += word.GetDisplayText() + " "; // Add a space between words
        }
        return displayText.TrimEnd(); // Remove the last space
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden(){
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Get the reference of the scripture
    public Reference GetReference(){
        return _reference;
    }
}
