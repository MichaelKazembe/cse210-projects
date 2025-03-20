using System;
using System.Collections.Generic;

public class PromptGenerator
{
    Random random = new Random();

    // Random prompts List
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today?",
        "What is something I am grateful for today?",
        "What is one goal I want to achieve tomorrow?",
        "What made me smile today?"
    };

    // Choose a random prompt
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count); 
        return _prompts[index];
    }

}