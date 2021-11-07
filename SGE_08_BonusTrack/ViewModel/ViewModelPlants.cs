using BonusTrack_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonusTrack_UI.ViewModel
{
    public class ViewModelPlants
    {
        private List<string> listOfPlantsName;
        private string detailsOfAPlant;

        public ViewModelPlants(string name){
            listOfPlantsName = new DALPlant().getListOfPlantsName();
            detailsOfAPlant = new DALPlant().getDetailsPlantSelected(name);
        }

        public List<string> ListOfPlantsName { get => listOfPlantsName; set => listOfPlantsName = value; }
        public string DetailsOfAPlant { get => detailsOfAPlant; set => detailsOfAPlant = value; }
    }
}
