using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickJutsu
{
    class Personnage : Carte
    {
        #region ATTRIBUTS
        int numero;
        int attaque;
        int defense;
        int vitesse;
        int force;
        bool allignement;        
        #endregion

        #region CONSTRUCTEUR  
        public Personnage(int uneAttaque, int uneDefense, int uneVitesse, int uneForce, bool unAllignement, int unNumero, string unNom) : base (unNumero, unNom)
        {
            this.numero = unNumero;
            this.attaque = uneAttaque;
            this.defense = uneDefense;
            this.vitesse = uneVitesse;
            this.force = uneForce;
            this.allignement = unAllignement;
        }
        #endregion

        #region ACCESSEURS
        public int Attaque
        {
            get
            {
                return attaque;
            }

            set
            {
                attaque = value;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public int Vitesse
        {
            get
            {
                return vitesse;
            }

            set
            {
                vitesse = value;
            }
        }

        public int Force
        {
            get
            {
                return force;
            }

            set
            {
                force = value;
            }
        }

        public bool Allignement
        {
            get
            {
                return allignement;
            }

            set
            {
                allignement = value;
            }
        }
        #endregion
    }
}
