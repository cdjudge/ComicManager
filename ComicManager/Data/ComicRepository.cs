using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicManager.Data.Entities;

namespace ComicManager.Data
{
    public class ComicRepository : IComicRepository
    {
        private readonly ComicManagerContext _ctx;
        public ComicRepository(ComicManagerContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Comic> GetAllComics()
        {
            return _ctx.Comics
                .OrderBy(comic => comic.name)
                .ToList();
        }

        public IEnumerable<Comic> GetComicsByPricePaid()
        {
            return _ctx.Comics
                .OrderBy(comic => comic.price_paid)
                .ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
