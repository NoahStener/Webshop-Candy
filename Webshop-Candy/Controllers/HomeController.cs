using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webshop_Candy.Models;
using Webshop_Candy.Service;
using Webshop_Candy.ViewModels;

namespace Webshop_Candy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _candyRepo;

        public HomeController(ICandyRepository candyRepo)
        {
            _candyRepo = candyRepo;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepo.GetCandyOnSale,
            };


            return View(homeViewModel);
        }
    }
}
