using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var fixedDate = new DateTime(2025, 05, 23, 15, 00, 00, DateTimeKind.Utc);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went swimming",
                    Description = "Went swimming with James",
                    CreatedAt = fixedDate
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went to the gym",
                    Description = "Went to the gym with James",
                    CreatedAt = fixedDate
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went to the movies",
                    Description = "Went to the movies with James",
                    CreatedAt = fixedDate
                },
                new DiaryEntry
                {
                    Id = 4,
                    Title = "Went to the park",
                    Description = "Went to the park with Mary",
                    CreatedAt = fixedDate
                }
            );
        }

    }
}
