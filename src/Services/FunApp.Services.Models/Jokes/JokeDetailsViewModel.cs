using FunApp.Data.Models;
using FunApp.Services.Mapping;

namespace FunApp.Web.Model.Jokes
{
    public class JokeDetailsViewModel : IMapFrom<Joke>
    {
        public string Content { get; set; }

        public string CategoryName { get; set; }
    }
}
