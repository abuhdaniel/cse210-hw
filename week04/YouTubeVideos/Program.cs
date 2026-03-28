using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Basics", "Abuh Daniel", 300);
        video1.AddComment(new Comment("Ozioma", "Great video!"));
        video1.AddComment(new Comment("Ivanna", "Very helpful."));
        video1.AddComment(new Comment("Brianna", "Nice explanation."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("OOP in C#", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "Clear and simple."));
        video2.AddComment(new Comment("Milana", "Loved it!"));
        video2.AddComment(new Comment("Frank", "Good examples."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Advanced C#", "Mike Brown", 600);
        video3.AddComment(new Comment("Grace", "Very detailed."));
        video3.AddComment(new Comment("Henry", "Learned a lot."));
        video3.AddComment(new Comment("Ivy", "Excellent content."));
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Comments: " + video.GetCommentCount());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment._commenterName + ": " + comment._text);
            }

            Console.WriteLine("------------------------");
        }
    }
}