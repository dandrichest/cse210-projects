using System;
using System.Collections.Generic;

namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3 videos with comments
        Video video1 = new Video("Learning C#", "David", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "I learned a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you cover advanced topics next time?"));
        videos.Add(video1);

        Video video2 = new Video("Exploring Python", "Deborah", 750);
        video2.AddComment(new Comment("Alice", "Python tutorial is so useful, thanks for explaining!"));
        video2.AddComment(new Comment("Emma", "Wonderful examples, keep it up!"));
        video2.AddComment(new Comment("Sophia", "Love the way you break down concepts."));
        videos.Add(video2);

        Video video3 = new Video("Async Programming in C#", "Daniel", 900);
        video3.AddComment(new Comment("John", "Async is confusing but you made it simpler."));
        video3.AddComment(new Comment("Lucy", "Could you add more examples?"));
        video3.AddComment(new Comment("Mike", "Great session on async and await."));
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}