using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        private List<Comment> comments;

        public Video(string title, string author, int length)
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

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}    