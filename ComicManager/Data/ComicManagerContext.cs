using System;
using ComicManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComicManager.Data
{
    public class ComicManagerContext :DbContext
    {
        public ComicManagerContext(DbContextOptions<ComicManagerContext> options) : base(options)
        {

        }
        public DbSet<Comic> Comics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comic>()
                .HasData(new Comic()
                {
                    id = 1,
                    name = "Sample Comic",
                    issue_number = "1",
                    volume_name = "Sample Volume",
                    thumb_nail_url = "xxx",
                    date_aquired = DateTime.UtcNow.ToShortDateString()+" "+ DateTime.UtcNow.ToShortTimeString()
                });
            modelBuilder.Entity<Comic>()
                .HasData(new Comic()
                {
                    id = 2,
                    name = "Sample Comic",
                    issue_number = "2",
                    volume_name = "Sample Volume",
                    thumb_nail_url = "xxx",
                    date_aquired = DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString()
                });
        }
    }
}
