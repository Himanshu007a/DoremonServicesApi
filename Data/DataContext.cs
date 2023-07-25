using DoremonServicesApi.Models;
using Microsoft.EntityFrameworkCore;



namespace DoremonServicesApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Doremon> Doremons { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DoremonOwner> DoremonOwners { get; set; }
        public DbSet<DoremonCategory> DoremonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<DoremonCategory>()
                .HasKey(pc => new {pc.DoremonId,pc.CategoryId});
            modelbuilder.Entity<DoremonCategory>()
                .HasOne(p => p.Doremon)
            .WithMany(pc => DoremonCategories)
            .HasForeignKey(pc => pc);

        }
    }
}
