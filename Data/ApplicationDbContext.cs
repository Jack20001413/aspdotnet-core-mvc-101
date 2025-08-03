using System;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<DiaryEntry> DiaryEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        System.Console.WriteLine(modelBuilder.Model.ToDebugString());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSeeding((context, _) =>
        {
            var testDiaryEntry = context.Set<DiaryEntry>().FirstOrDefault(e => e.Title == "Lost in Humanity");
            if (testDiaryEntry == null)
            {
                context.Set<DiaryEntry>().Add(new DiaryEntry
                {
                    // Id = 0,
                    Title = "Lost in Humanity",
                    Content = "By Dazai Osamu",
                    CreatedAt = DateTime.Now
                });
                context.SaveChanges();
            }
        });
        // .UseAsyncSeeding(async (context, _, cancellationToken) =>
        // {
        //     var testDiaryEntry = await context.Set<DiaryEntry>().FirstOrDefaultAsync(e => e.Title == "Lost in Humanity", cancellationToken);
        //     if (testDiaryEntry == null)
        //     {
        //         context.Set<DiaryEntry>().Add(new DiaryEntry
        //         {
        //             // Id = 0,
        //             Title = "Lost in Humanity",
        //             Content = "By Dazai Osamu",
        //             CreatedAt = DateTime.Now
        //         });
        //         await context.SaveChangesAsync(cancellationToken);
        //     }
        // });
    }
}
