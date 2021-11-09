using System;

namespace BonusTrack_Entities
{
    public class clsPlant
    {

        #region atributes
        private string name;
        private string details;
        #endregion

        #region constructors
        public clsPlant(string nombre,string detalles){
            this.name = nombre;
            this.details = detalles;
        }

        public clsPlant()
        {
            this.name = "";
            this.details = "";
        }
        #endregion

        #region getters & setters
        public string Name { get => name; set => name = value; }
        public string Details { get => details; set => details = value; }
        #endregion
    
    }

}
