using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedGameList.Models
{
    public enum Genre
    {
        Undefined,
        Story,
        Action,
        Horror,
        Strategy
    }

    public class Game
    {
        public int Id { get; set; }
        public int DeveloperId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        //one game has one developer
        public virtual Developer Developer { get; set; }
        //one game has many reviews
        public virtual ICollection<Review> Reviews { get; set; }
    }
}