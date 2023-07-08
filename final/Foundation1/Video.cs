using System;
using System.Collections.Generic;

namespace Abstraction
{
    //This program demonstrates the concept of abstraction by creating a simple video and comment system. 
    //Here's a breakdown of what the program does:
    class Video
    {
        public string Title;
        public string Author;
        public int Length;
        private List<Comment> comments;

        public Video(string title, string author, int length) // stores a list of comments for that video.
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        public void AddComment(string commenter, string text)
        {
            Comment comment = new Comment(commenter, text);
            comments.Add(comment);
        }

        public int GetNumberOfComments() //  prints the title, author, length, and the number of comments using the GetNumberOfComments method.
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}    