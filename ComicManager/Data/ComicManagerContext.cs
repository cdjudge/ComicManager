using ComicManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComicManager.Data
{
    public class ComicManagerContext :DbContext
    {
        public ComicManagerContext(DbContextOptions<ComicManagerContext> options) : base(options)
        {

        }
        public DbSet<Result> Comics { get; set; }
    }
}
