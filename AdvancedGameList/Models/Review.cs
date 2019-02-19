using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedGameList.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public double ScoreCap { get; set; }
        public double Score { get; set; }

        //one review has one game
        public virtual Game Game { get; set; }
    }
}