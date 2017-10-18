using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Case
    {
        #region ATTRIBUTS
        Carte carte;
        Joueur joueur;
        #endregion

        #region CONSTRUCTEUR 
        public Case()
        {
            this.carte = null;
            this.joueur = null;
        }
        public Case(Carte uneCarte, Joueur unJoueur)
        {
            this.carte = uneCarte;
            this.joueur = unJoueur;
        }        
        #endregion

        #region ACCESSEURS  
        public Carte Carte
        {
            get
            {
                return carte;
            }

            set
            {
                carte = value;
            }
        }

        public Joueur Joueur
        {
            get
            {
                return joueur;
            }

            set
            {
                joueur = value;
            }
        }
        #endregion
    }
}
