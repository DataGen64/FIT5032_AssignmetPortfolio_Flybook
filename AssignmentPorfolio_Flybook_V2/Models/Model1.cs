namespace AssignmentPorfolio_Flybook_V2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Flybook")
        {
        }

        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasOptional(e => e.Rating)
                .WithRequired(e => e.Booking);

            modelBuilder.Entity<Flight>()
                .Property(e => e.From_Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<Flight>()
                .Property(e => e.From_Longitude)
                .HasPrecision(11, 8);

            modelBuilder.Entity<Flight>()
                .Property(e => e.To_Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<Flight>()
                .Property(e => e.To_Longitude)
                .HasPrecision(11, 8);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Flight)
                .HasForeignKey(e => e.Flight_id)
                .WillCascadeOnDelete(false);
        }
    }
}
