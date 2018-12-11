using System.Collections.Generic;
using ComicManager.Data.Entities;

namespace ComicManager.Data
{
    public interface IComicRepository
    {
        IEnumerable<Comic> GetAllComics();
        IEnumerable<Comic> GetComicsByPricePaid();
        bool SaveAll();
    }
}