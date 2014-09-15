using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HHS.EF
{
    public class VoetbalContext : DbContext
    {
        public VoetbalContext() : base("VoetbalContext")
        {

        }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Team>()
                .Property(p => p.Naam)
                .HasMaxLength(23);
        }
    }
}
