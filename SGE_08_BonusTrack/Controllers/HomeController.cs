using BonusTrack_UI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonusTrack_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewModelPlants viewModel = new ViewModelPlants("");
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewModelPlants viewModel = new ViewModelPlants(name);
            return View(viewModel);
        }
    }
}
