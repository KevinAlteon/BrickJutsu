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
        int taille;
        Case[,] lesCases;

        
        #endregion

        #region CONSTRUCTEUR  
        public Plateau_kevin(int uneTaille)
        {
            this.Taille = uneTaille;
            this.lesCases = new Case[uneTaille + 1, uneTaille + 1];
            for (int i = 0; i <= uneTaille + 1; i++)
            {
                for (int j = 0; j <= uneTaille + 1; j++)
                {
                    this.lesCases[i, j] = new Case();
                }
            }
        }
        #endregion

        #region ACCESSEURS 
        public int Taille
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
