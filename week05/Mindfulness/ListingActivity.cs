public class ListingActivity : ListingActivity 
{
    private int _count;
    private List<string> _prompts;

    //  Constructor    
    public ListingActivity( int count, List<string> prompts)
    {
        _count = count;
        _prompts = prompts;
    }

    // Getters
    public int GetCount()
    {
        return _count;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    //  Methods
    public void Run()
    {
        Console.WriteLine("Running...");
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("Getting Random Prompt ...");
    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine("Getting List From User ...");
    }

}