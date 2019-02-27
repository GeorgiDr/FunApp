using FunApp.Services.Models.Home;
using System.Collections.Generic;

namespace FunApp.Services.DataServices
{
    public interface IJokeService
    {
        IEnumerable<IndexJokeViewModel> GetRandomJokes(int count);

        int GetCount();
    }
}
