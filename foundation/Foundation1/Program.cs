using System;

class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("Understanding Abstraction", "John Doe", 600);
            Video video2 = new Video("Programming Basics", "Jane Smith", 720);
            Video video3 = new Video("Advanced C# Techniques", "Alice Johnson", 840);

            // Add comments to video1
            video1.AddComment(new Comment("Mike", "This video is amazing!"));
            video1.AddComment(new Comment("Sarah", "Great explanation!"));
            video1.AddComment(new Comment("Chris", "Really helpful, thanks!"));

            // Add comments to video2
            video2.AddComment(new Comment("Anna", "This helped me get started with programming."));
            video2.AddComment(new Comment("Tom", "Clear and concise."));
            video2.AddComment(new Comment("Lucy", "Loved this tutorial!"));

            // Add comments to video3
            video3.AddComment(new Comment("James", "Advanced topics explained well."));
            video3.AddComment(new Comment("Emma", "Looking forward to more videos."));
            video3.AddComment(new Comment("Liam", "Very informative."));

            // Store videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Display information about each video
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
    }