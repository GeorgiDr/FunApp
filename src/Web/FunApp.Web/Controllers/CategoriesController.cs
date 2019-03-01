using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FunApp.Services.DataServices;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace FunApp.Web.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IJokeService jokeService;

        public CategoriesController(
            ICategoriesService categoriesService,
            IJokeService jokeService)
        {
            this.categoriesService = categoriesService;
            this.jokeService = jokeService;
        }
        public IActionResult Index()
        {
            var categories = categoriesService.GetAll().ToList();

            return this.View(categories);
        }

        public IActionResult Details(int id, int? page)
        {
            var jokesInCategory = this.jokeService.GetAllByCategory(id).ToList();

            var nextPage = page ?? 1;

            var pagedJokes = jokesInCategory.ToPagedList(nextPage, 4);

            return this.View(pagedJokes);
        }
    }
}
