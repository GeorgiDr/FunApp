using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FunApp.Services.DataServices;
using Microsoft.AspNetCore.Mvc;

namespace FunApp.Web.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            var categories = categoriesService.GetAll().ToList();

            return this.View(categories);
        }

        public IActionResult Details(int id)
        {
            throw new ArgumentException();
        }
    }
}
