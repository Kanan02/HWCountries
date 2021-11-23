using CodefirstCountry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry
{
    public class CountryContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<ParticipantMedal> ParticipantMedals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies() .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Step2;Integrated Security=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>()
        .HasMany(c => c.Participants)
        .WithOne(e => e.Country);

            modelBuilder.Entity<Sport>()
        .HasMany(c => c.Participants)
        .WithOne(e => e.Sport);


            modelBuilder.Entity<ParticipantMedal>()
      .HasKey(bc => new { bc.ParticipantId, bc.MedalId });
            modelBuilder.Entity<ParticipantMedal>()
                .HasOne(bc => bc.Participant)
                .WithMany(b => b.ParticipantMedals)
                .HasForeignKey(bc => bc.ParticipantId);
            modelBuilder.Entity<ParticipantMedal>()
                .HasOne(bc => bc.Medal)
                .WithMany(c => c.ParticipantMedals)
                .HasForeignKey(bc => bc.MedalId);
        }
    }
}
