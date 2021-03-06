﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Collection
    {
        #region ATTRIBUTS
        string nom;
        DateTime dateCreation;
        List<Carte> lesCartes;
        #endregion

        #region CONSTRUCTEUR  
        public Collection(string unNom)
        {
            this.nom = unNom;
            this.dateCreation = DateTime.Now;
            this.LesCartes = new List<Carte>();
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

        public DateTime DateCreation
        {
            get
            {
                return dateCreation;
            }

            set
            {
                dateCreation = value;
            }
        }

        public List<Carte> LesCartes
        {
            get
            {
                return lesCartes;
            }

            set
            {
                lesCartes = value;
            }
        }
        #endregion
        public void ajouterCarte(Carte uneCarte)
        {
            this.LesCartes.Add(uneCarte);
        }
    }
}
