using System;
using System.Collections.Generic;
using System.Text;

namespace nightAtMuseum
{
    public class Room
    {
        public string Name { get; set; }
        public Room roomUp { get; set; }
        public Room roomRight { get; set; }
        public Room roomDown { get; set; }
        public Room roomLeft { get; set; }
        public List<Artwork> artworks = new List<Artwork>();

        public Room(string name)
        {
            Name = name;
            
        }

        public void addArtwork(Artwork artwork)
        {
            artworks.Add(artwork);
        }

        public void printArtworks()
        {
            if (artworks.Count > 0)
            {
                Console.WriteLine("In this room you have the artworks:");
                foreach (var artwork in artworks)
                {
                    Console.WriteLine($"{artwork.Title} {artwork.Description} {artwork.Author}");
                }
            }
        }
     

    }
}
