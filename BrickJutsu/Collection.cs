using System;
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
        List<Personnage> lesCartes;
        #endregion

        #region CONSTRUCTEUR  
        public Collection(string unNom)
        {
            this.nom = unNom;
            this.dateCreation = DateTime.Now;
            this.LesCartes = new List<Personnage>();
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

        internal List<Personnage> LesCartes
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
        public void ajouterCarte(Personnage uneCarte)
        {
            this.LesCartes.Add(uneCarte);
        }
    }
}
