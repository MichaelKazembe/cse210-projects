using System

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.Clear();

       for (int i = 5; i > 0; i--)
       {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        
       }

    }
}