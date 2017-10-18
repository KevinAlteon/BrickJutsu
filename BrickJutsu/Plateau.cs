using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Plateau
    {
        #region ATTRIBUTS
        string taille;
        #endregion

        #region CONSTRUCTEUR  
        public Plateau(string uneTaille)
        {
            this.taille = uneTaille;
        }
        #endregion

        #region ACCESSEURS 
        public string Taille
        {
            get
            {
                return taille;
            }

            set
            {
                taille = value;
            }
        }
        #endregion













    }
}
