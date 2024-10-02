using DairyApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DairyApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<DiaryEntry>().HasData(
            new DiaryEntry(1, "Title 1", "Description 1", DateTime.Now),
            new DiaryEntry(2, "Title 2", "Description 2", DateTime.Now),
            new DiaryEntry(3, "Title 3", "Description 3", DateTime.Now)
            );
    }
}
