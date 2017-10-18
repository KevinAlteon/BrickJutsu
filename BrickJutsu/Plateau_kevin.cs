using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Plateau_kevin
    {
        #region ATTRIBUTS
        string taille;
        #endregion

        #region CONSTRUCTEUR  
        public Plateau_kevin(string uneTaille)
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
