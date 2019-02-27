using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FunApp.Web.Models;
using FunApp.Data.Common;
using FunApp.Data.Models;
using FunApp.Services.DataServices;
using FunApp.Services.Models.Home;
using FunApp.Services.Models;

namespace FunApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        
        private readonly IJokeService jokeService;

        public HomeController(IJokeService jokeService)
        {
            this.jokeService = jokeService;
        }

        public IActionResult Index()
        {
            var jokes = this.jokeService.GetRandomJokes(10);
            var viewModel = new IndexViewModel
            {
                Jokes = jokes,
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"My application has {this.jokeService.GetCount()} jokes.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
