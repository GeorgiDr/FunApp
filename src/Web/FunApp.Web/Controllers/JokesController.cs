using FunApp.Services.DataServices;
using FunApp.Web.Model.Jokes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Web.Controllers
{
    public class JokesController : BaseController
    {
        private readonly IJokeService jokeService;
        private readonly ICategoriesService categoriesService;

        public JokesController(IJokeService jokeService, ICategoriesService categoriesService)
        {
            this.jokeService = jokeService;
            this.categoriesService = categoriesService;
        }

        [Authorize]
        public IActionResult Create()
        {
            this.ViewData["Categories"] = this.categoriesService.GetAll()
                .Select(x => new SelectListItem
                     {
                         Value = x.Id.ToString(),
                         Text = x.Name,
                     });
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateJokeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            var id = await this.jokeService.Create(input.CategoryId, input.Content);
            return this.RedirectToAction("Details", new {id = id });
        }

        public IActionResult Details(int id)
        {
            return this.View();
        }
    }
}
