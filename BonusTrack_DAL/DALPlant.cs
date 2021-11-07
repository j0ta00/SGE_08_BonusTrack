using BonusTrack_Entities;
using System;
using System.Collections.Generic;

namespace BonusTrack_DAL
{
    public class DALPlant
    {
        private List<clsPlant> listOfPlants = new List<clsPlant>();

        public DALPlant(){
            listOfPlants.Add(new clsPlant("Aloe vera", "De la familia de las Asphodelaceae, pertenece al género Aloe, que cuenta con más de 350 especies vegetales. Esta especie, muy habitual entre las plantas de interior, tiene infinidad de aplicaciones en diversos remedios naturales, especialmente para los de la piel. Entre ellas, la de aliviar las quemaduras, rozaduras e, incluso, psoriasis y picaduras de insectos."));
            listOfPlants.Add(new clsPlant("Valeriana", "La valeriana o Valeriana officinalis es una de las plantas medicinales más empleadas en la fitoterapia. Y es normal, ya que tiene infinidad de beneficios pero quizás el más conocido sea el ayudar a relajarnos. La valeriana es una planta que disminuye la ansiedad y ayuda a dormir."));
            listOfPlants.Add(new clsPlant("Amapola", "La amapola o Papaver rhoeas L., es una planta curativa de la que se usan las semillas. Con estas semillas se consigue prevenir enfermedades cardiovasculares, anemias o afecciones de la piel."));
            listOfPlants.Add(new clsPlant("Eucalipto", "El eucalipto o eucaliptas es una de las plantas que más usamos para decorar la casa. Son plantas muy resistentes y perfectas para añadir a cualquier centro de mesa. Pero además de decorar el interior de nuestra casa, los eucaliptos son plantas medicinales muy beneficiosas para la salud. Entre sus propiedades más conocidas está la de aliviar los síntomas de los resfriados, en concreto afecciones respiratorias (tos, bronquitis, neumonía, asma...)."));
            listOfPlants.Add(new clsPlant("Salvia", "La salvia o Salvia officinalis es una de las plantas más conocidas por utilizarse en cosméticos, pero también tiene otras funciones. Entre las más conocidas está su utilización para aliviar los síntomas de la menopausia."));
            listOfPlants.Add(new clsPlant("Arándanos", "Los arándanos o también llamado como cranberry (o Vaccinium macrocarpon) junto con las frambuesas son algunos de los ingredientes principales de los boles que más verás en un desayuno saludable. Pues bien, los arándanos, muy populares en la fitoterapia, a pesar de ser muy pequeños, cuentan con muchas propiedades, entre las que destaca su capacidad antibacteriana, ya que ayuda a combatir infecciones."));
        }

        /// <summary>
        /// Method that simulate a connection with a database, wich you get information, and gives who call it, a list with all plants names (a list of strings)
        /// </summary>
        /// <returns> List<string> listOfPlantsName </returns>
        public List<string> getListOfPlantsName(){
            List<string> listOfPlantsName = new List<string>();
            foreach (clsPlant plant in listOfPlants){
                listOfPlantsName.Add(plant.Name);
            }
            return listOfPlantsName;
        }
        /// <summary>
        /// Method that simulate a connection with a database, wich you get information, and gives who call it, the
        /// details of a plant that coincidate with the name of the string param
        /// </summary>
        /// <param name="name">string name</param>
        /// <returns> string DetallesDePlantSeleccionada </returns>
        public string getDetailsPlantSelected(string name)
        {
            return name == "" ? "":(listOfPlants.Find(plant => plant.Name.Equals(name)).Details);
        }
    }
}
