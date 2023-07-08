using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Comment
    {
        public string Commenter { get; set; } // store the name or identifier of the person who made the comment
        public string Text { get; set; }

        public Comment(string commenter, string text) // create instances of the Comment.  
        {
            Commenter = commenter;
            Text = text;
        }
    }
}
    