using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvancedGameList.Models;
using System.Data.Entity;

namespace AdvancedGameList.DAL
{
    public class GameInitializer : DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var developers = new List<Developer>
            {
                new Developer{ Name="Respawn", Location="San Fernando Valley", IsAAA=true},
                new Developer{ Name="Infinite Fall", Location="Winnipeg", IsAAA=false},
                new Developer{ Name="Atlas", Location="Minato, Tokyo, Japan", IsAAA=true},
            };

            developers.ForEach(s => context.Developers.Add(s));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game{ Name="Apex Legends", Genre=Genre.Action, ReleaseDate= new DateTime(2019, 1, 1), DeveloperId=1 },
                new Game{ Name="Night In The Woods", Genre=Genre.Story, ReleaseDate= new DateTime(2018, 3, 24), DeveloperId=2 },
                new Game{ Name="Persona 4", Genre=Genre.Story, ReleaseDate= new DateTime(2012, 5, 19), DeveloperId=3 },

            };

            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
                new Review{ Name="Polygon", Text="Is a good BR I guess.", ScoreCap=10.00, Score=8, GameId=1},
                new Review{ Name="Game Spot", Text="Very sad.", ScoreCap=5.00, Score=5, GameId=2},
                new Review{ Name="Jim Sterling", Text="It's like anime.", ScoreCap=10.00, Score=9, GameId=3},
            };

            reviews.ForEach(s => context.Reviews.Add(s));
            context.SaveChanges();
        }
    }
}