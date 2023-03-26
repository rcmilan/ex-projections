using ex_projections.Entities;
using Microsoft.EntityFrameworkCore;

namespace ex_projections.Configurations
{
    public class CustomDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>()
                .OwnsOne(u => u.Address).WithOwner();

            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired();
        }
    }
}
