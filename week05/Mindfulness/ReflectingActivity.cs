public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity(List<string> prompts, List<string> questions)
    {
        _prompts = prompts;
        _questions = questions;
    }

    // Getters
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }

    //  Methods
    public void Run()
    {
        Console.WriteLine("Running ...");
    }

    public string GetRandomQuestion()
    {
        Console.WriteLine("Getting Random Question ...");
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Prompt");
    }

    public DisplayQuestions()
    {
        Console.WriteLine("Questions");
    }
}