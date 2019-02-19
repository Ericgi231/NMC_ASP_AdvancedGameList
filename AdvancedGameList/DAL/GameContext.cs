using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvancedGameList.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AdvancedGameList.DAL
{
    public class GameContext : DbContext
    {
        public GameContext() : base("GameContext")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}