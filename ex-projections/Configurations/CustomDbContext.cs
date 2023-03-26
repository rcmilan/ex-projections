using ex_projections.Entities;
using Microsoft.EntityFrameworkCore;

namespace ex_projections.Configurations
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>()
                .Navigation(u => u.Address)
                .AutoInclude();

            modelBuilder.Entity<User>()
                .OwnsOne(u => u.Address).WithOwner();

            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PersonalData1)
                .IsRequired(false);

            modelBuilder.Entity<User>()
                .Property(u => u.PersonalData2)
                .IsRequired(false);

            modelBuilder.Entity<User>()
                .Property(u => u.PersonalData3)
                .IsRequired(false);
        }
    }
}