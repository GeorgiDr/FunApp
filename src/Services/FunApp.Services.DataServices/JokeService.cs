using FunApp.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using FunApp.Data.Common;
using FunApp.Services.Models.Home;

namespace FunApp.Services.DataServices
{
    public class JokeService : IJokeService
    {
        private readonly IRepository<Joke> jokesRepository;

        public JokeService(IRepository<Joke> jokesRepository)
        {
            this.jokesRepository = jokesRepository;
        }

        public IEnumerable<IndexJokeViewModel> GetRandomJokes(int count)
        {

            var jokes = this.jokesRepository.All()
                // Add Random
                .OrderBy(x => Guid.NewGuid())
                .Select(x => new IndexJokeViewModel
                {
                    Content = x.Content,
                    CategoryName = x.Category.Name,
                }).Take(count).ToList();

            return jokes;
        }

        public int GetCount()
        {
            return this.jokesRepository.All().Count();
        }
    }
}
