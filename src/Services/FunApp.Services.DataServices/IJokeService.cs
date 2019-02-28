using FunApp.Services.Models.Home;
using FunApp.Web.Model.Jokes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.Services.DataServices
{
    public interface IJokeService
    {
        IEnumerable<IndexJokeViewModel> GetRandomJokes(int count);

        int GetCount();

        Task<int> Create(int categoryId, string content);

        TViewModel GetJokeById<TViewModel>(int id);
    }
}
