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
        string descritpion;
        #endregion

        #region CONSTRUCTEUR      
        public Action(string uneDescription, int unNumero, string unNom) : base (unNumero, unNom)
        {
            this.descritpion = uneDescription;
        }
        #endregion

        #region ACCESSEURS 
        public string Descritpion
        {
            get
            {
                return descritpion;
            }

            set
            {
                descritpion = value;
            }
        }
        #endregion
    }
}
