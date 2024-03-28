using FinPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace FinPlanner.Infrastructure.Persistance
{
    internal class FinPlannerDbContext : DbContext
    {
        internal DbSet<Budget> Budgets { get; set; }
        internal DbSet<Group> Groups { get; set; }
        internal DbSet<GroupItem> GroupItems { get; set; }
        internal DbSet<Asset> Assets { get; set; }

        public FinPlannerDbContext(DbContextOptions<FinPlannerDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Budget>()
                .HasMany(b => b.Groupes)
                .WithOne()
                .HasForeignKey(g => g.BudgetId);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.GroupItems)
                .WithOne()
                .HasForeignKey(gi => gi.GroupId);
        }
    }
}
