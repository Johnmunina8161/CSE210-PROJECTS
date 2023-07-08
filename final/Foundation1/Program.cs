using System;
using System.Collections.Generic;  
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("Video 1", "Author 1", 120);
            video1.AddComment("User A", "Great video!");
            video1.AddComment("User B", "I learned a lot from this.");
            video1.AddComment("User C", "Could you make a tutorial on this topic?");
            
            Video video2 = new Video("Video 2", "Author 2", 180);
            video2.AddComment("User D", "Nice work!");
            video2.AddComment("User E", "This video helped me a lot.");
            
            Video video3 = new Video("Video 3", "Author 3", 90);
            video3.AddComment("User F", "Awesome content!");
            video3.AddComment("User G", "I have a question regarding the video.");
            video3.AddComment("User H", "Please upload more videos on this subject.");

            // Create a list of videos
            List<Video> videos = new List<Video>(); // This  List<Video> named videos is created to store the created video objects.
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Display video information
            foreach (Video video in videos) //  iterate over each video in the videos list.
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length: " + video.Length + " seconds");
                Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
                
                Console.WriteLine("Comments:");
                List<Comment> comments = video.GetComments();
                foreach (Comment comment in comments)
                {
                    Console.WriteLine("Commenter: " + comment.Commenter);
                    Console.WriteLine("Text: " + comment.Text);
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

    