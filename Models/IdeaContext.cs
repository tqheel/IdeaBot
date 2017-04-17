using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IdeaBot.Models
{
    public class IdeaContext : DbContext
    {
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<IdeaBatch> IdeaBatches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ideas.db");
        }
    }
}