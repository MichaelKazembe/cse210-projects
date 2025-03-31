using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Create instances of Video
        Video video1 = new Video("C# Tutorial", "Michael Kazembe", 120);
        Video video2 = new Video("Python Tutorial", "Karen Kazembe", 60);
        Video video3 = new Video("Java Tutorial", "Jack Thundie", 30);

        // Add Comments
        video1.AddComment(new Comment("Henz", "This was really helpful, thanks!"));
        video1.AddComment(new Comment("Mercy", "Loved the explanation, very clear!"));
        video1.AddComment(new Comment("Billy", "I learned something new today."));
        
        video2.AddComment(new Comment("Sophia", "Amazing content, keep it up!"));
        video2.AddComment(new Comment("Liam", "This video made my day better!"));
        video2.AddComment(new Comment("Emma", "Short and to the point, great job!"));
        
        video3.AddComment(new Comment("Oliver", "I’ve been looking for this, thank you!"));
        video3.AddComment(new Comment("Ava", "Can’t wait to see more videos like this!"));
        video3.AddComment(new Comment("Ethan", "This was exactly what I needed."));

        // Add Videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display all comments
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }
    }
}