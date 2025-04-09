public class Activity 
{
   private string _name;
   private string _description;
   private int _duration;

    //  Constructor

   public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //  Getters  
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //  Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Message");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Message");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner...");
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Counting down: 3 2 1");
    }
}
