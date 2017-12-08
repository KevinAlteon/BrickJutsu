using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Joueur
    {
        #region ATTRIBUTS
        string nom;
        #endregion

        #region CONSTRUCTEUR
        public Joueur(string unNom)
        {
            this.nom = unNom;
        }
        #endregion

        #region ACCESSEURS 
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        #endregion
    }
}
