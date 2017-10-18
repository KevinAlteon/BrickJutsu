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
        #endregion

        #region CONSTRUCTEUR  
        public Carte (string unNom, int unNumero)
        {
            this.nom = unNom;
            this.numero = unNumero;
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
        #endregion


    }
}
