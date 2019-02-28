using FunApp.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using FunApp.Data.Common;
using FunApp.Services.Models.Home;
using System.Threading.Tasks;
using FunApp.Web.Model.Jokes;
using FunApp.Services.Mapping;

namespace FunApp.Services.DataServices
{
    public class JokeService : IJokeService
    {
        private readonly IRepository<Joke> jokesRepository;
        private readonly IRepository<Category> categoriesRepository;

        public JokeService(
            IRepository<Joke> jokesRepository,
            IRepository<Category> categoriesRepository)
        {
            this.jokesRepository = jokesRepository;
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<IndexJokeViewModel> GetRandomJokes(int count)
        {

            var jokes = this.jokesRepository.All()
                // Add Random
                .OrderBy(x => Guid.NewGuid())
                .To<IndexJokeViewModel>()
                .Take(count).ToList();
                
            return jokes;
        }

        public int GetCount()
        {
            return this.jokesRepository.All().Count();
        }

        public async Task<int> Create(int categoryId, string content)
        {
           var joke = new Joke
           {
               CategoryId = categoryId,
               Content = content,
           };
           await this.jokesRepository.AddAsync(joke);
           await this.jokesRepository.SaveChangeAsync();

           return joke.Id;
        }

        public JokeDetailsViewModel GetJokeById<TViewModel>(int id)
        {
         var joke = this.jokesRepository.All().Where(x => x.Id == id)
             .To<TViewModel>().FirstOrDefault();

         return joke;
        }
    }
}
