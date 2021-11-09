using BonusTrack_DAL;
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
            ViewModelPlants viewModel = new ViewModelPlants();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(string selectPlants)
        {
            ViewModelPlants viewModel = new ViewModelPlants();
            viewModel.DetailsOfAPlant = new DALPlant().getDetailsPlantSelected(selectPlants);
            return View(viewModel);
        }
    }
}
