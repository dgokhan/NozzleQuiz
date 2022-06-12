using Microsoft.EntityFrameworkCore;
using NozzleQuiz.Domain.Entities;

namespace NozzleQuiz.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MaterialCategory> MaterialCategory { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<BaseUnitType> BaseUnitType { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
