using System;
using System.Collections.Generic;

public class PromptGenerator
{
    Random random = new Random();

    // Random prompts List
    List<string> prompts = new List<string>
    {
        "What is your favorite color?",
        "What is your favorite food?",
        "What is your favorite movie?",
        "What is your favorite song?",
        "What is your favorite book?",
        "What is your favorite animal?",
        "What is your favorite place?",
        "What is your favorite season?",
        "What is your favorite memory?",
        "What is your favorite hobby?",
        "What is your favorite sport?",
        "What is your favorite subject?",
        "What is your favorite game?",
        "What is your favorite TV show?",
        "What is your favorite restaurant?",
        "What is your favorite store?",
    };

    // Choose a random prompt
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    // Display the random prompt
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
}