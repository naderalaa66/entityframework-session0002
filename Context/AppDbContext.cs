using ConsoleApp88.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=true;TrustServerCertificate=true");
        }
       
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().HasOne(x => x.myBadge)
                .WithOne(s => s.myAttendee)
                .HasForeignKey<Badge>(s => s.fkid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<organizer>(T =>
            {
                T.Property(x => x.organizerName)
                .HasMaxLength(100);
                T.Property(b => b.CompanyName)
                .HasMaxLength(150);
            });
            #region Notes
            //modelBuilder.Entity<Attendee>(b =>
            //{
            //    b.Property(s => s.FullName)
            //    .HasMaxLength(150);
            //    b.Property(v => v.Email)
            //    .HasMaxLength(200);
            //    b.Property(x => x.streatAdrees)
            //    .HasMaxLength(150);
            //    b.Property(x => x.CityAdrees)
            //    .HasMaxLength(100);
            //    b.Property(x => x.countryAdrees)
            //    .HasMaxLength(100);
            //    b.Property(x => x.symbolAdrees)
            //    .HasMaxLength(20);
            //});
            #endregion

            modelBuilder.Entity<organizer>().ToTable("EventOrganizers");
            //modelBuilder.Entity<Attendee>(x =>
            //{
            //    x.Property(c => c.Email).HasColumnName("ZipCode");
            //});

            modelBuilder.Entity<organizer>().HasOne(x => x.myorganizerprofile)
                .WithOne(s => s.myorganizer)
                .HasForeignKey<organizerprofile>(c => c.organizerId);

            modelBuilder.Entity<Event>().HasOne(x => x.myorganizer)
                .WithMany(z => z.myEvent)
                .HasForeignKey(c => c.organizerid)
                .OnDelete(DeleteBehavior.Cascade);

           












        }

        public DbSet<Attendee> Attends { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<organizer> organizers { get; set; }

        public DbSet<organizerprofile> organizerprofiles { get; set; }







    }
}