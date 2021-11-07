using BonusTrack_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonusTrack_UI.ViewModel
{
    public class ViewModelPlants
    {
        #region atributes
        private List<string> listOfPlantsName;
        private string detailsOfAPlant;
        #endregion

        #region constructors
        public ViewModelPlants(string name){
            listOfPlantsName = new DALPlant().getListOfPlantsName();
            detailsOfAPlant = new DALPlant().getDetailsPlantSelected(name);
        }
        #endregion

        #region getters & setter
        public List<string> ListOfPlantsName { get => listOfPlantsName; set => listOfPlantsName = value; }
        public string DetailsOfAPlant { get => detailsOfAPlant; set => detailsOfAPlant = value; }
        #endregion
    }
}
