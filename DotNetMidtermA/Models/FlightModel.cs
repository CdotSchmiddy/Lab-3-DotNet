namespace DotNetMidtermA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FlightModel : DbContext
    {
        public FlightModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightType> FlightTypes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<FlightType>()
                .Property(e => e.FlightType1)
                .IsUnicode(false);

            modelBuilder.Entity<FlightType>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.FlightType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.TaxRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);
        }
    }
}
