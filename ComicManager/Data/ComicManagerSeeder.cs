using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicManager.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace ComicManager.Data
{
    public class ComicManagerSeeder
    {
        private readonly ComicManagerContext _ctx;
        private readonly IHostingEnvironment _hosting;
        public ComicManagerSeeder(ComicManagerContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Comics.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath,"Data/SampleComics.json");
                var json = File.ReadAllText(filepath);
                var comics = JsonConvert.DeserializeObject<IEnumerable<Comic>>(json);
                _ctx.Comics.AddRange(comics);
                _ctx.SaveChanges();
            }
        }
    }
}
