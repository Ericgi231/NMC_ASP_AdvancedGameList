using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedGameList.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsAAA { get; set; }

        //one developer has many games
        public virtual ICollection<Game> Games { get; set; }
    }
}