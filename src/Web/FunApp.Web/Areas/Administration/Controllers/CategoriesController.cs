using AutoMapper;
using FunApp.Data.Common;
using FunApp.Data.Models;
using FunApp.Services.DataServices;
using FunApp.Web.Areas.Administration.Models.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Web.Areas.Administration.Controllers
{
    public class CategoriesController : AdministrationBaseController
    {
        private readonly ICategoriesService categoriesService;

        private readonly IRepository<Category> categories;

        public CategoriesController(ICategoriesService categoriesService, IRepository<Category> categories)
        {
            this.categoriesService = categoriesService;
            this.categories = categories;
        }

        public IActionResult Index()
        {
            var categories = categoriesService
                .GetAll()
                .ToList();
            
            return this.View(categories);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryInputModel model)
        {
            var newCategory = Mapper.Map<Category>(model);
            await this.categories.AddAsync(newCategory);
            await this.categories.SaveChangeAsync();
            return this.RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Edit(EditCategoryInputModel model)
        {
            return null;
        }


        public IActionResult Delete(int id)
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Delete(DeleteCategoryInputModel model)
        {
            return null;
        }
    }
}