using ComicManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComicManager.controllers
{
    public class AppController: Controller
    {
        private readonly IComicRepository _comicRepository;

        public AppController(IComicRepository repository)
        {
            _comicRepository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
