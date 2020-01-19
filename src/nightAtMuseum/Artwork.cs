using System;
using System.Collections.Generic;
using System.Text;

namespace nightAtMuseum
{
    public class Artwork
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }


        public Artwork(string title, string description, string author)
        {
            Title = title;
            Description = description;
            Author = author;
        }


    }
}
