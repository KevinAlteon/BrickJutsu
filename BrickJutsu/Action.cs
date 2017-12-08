using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Action : Carte
    {
        #region ATTRIBUTS
        string description;
        #endregion

        #region CONSTRUCTEUR      
        public Action(string uneDescription, int unNumero, string unNom) : base (unNumero, unNom)
        {
            this.description = uneDescription;
        }
        #endregion

        #region ACCESSEURS 
        public string Descritpion
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        #endregion
    }
}
