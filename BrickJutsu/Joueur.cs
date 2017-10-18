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
        string prenom;
        #endregion

        #region CONSTRUCTEUR
        public Joueur(string unNom, string unPrenom)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        #endregion
    }
}
