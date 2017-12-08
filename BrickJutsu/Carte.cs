using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Carte
    {
        #region ATTRIBUTS
        string nom;
        int numero;
        int nbExemplaire;
        string description;
        #endregion

        #region CONSTRUCTEUR  
        public Carte (int unNumero, string unNom)
        {
            this.nom = unNom;
            this.numero = unNumero;
            this.NbExemplaire = 0;
            this.Description = null;
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

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int NbExemplaire
        {
            get
            {
                return nbExemplaire;
            }

            set
            {
                nbExemplaire = value;
            }
        }

        public string Description
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
