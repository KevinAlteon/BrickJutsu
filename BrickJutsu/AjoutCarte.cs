using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrickJutsu
{
    public partial class AjoutCarte : MetroFramework.Forms.MetroForm
    {
        public AjoutCarte()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(retour));
            monthread.Start();
            this.Close();
        }

        public static void retour()
        {
            Application.Run(new Accueil());
        }

        // Vérification de la quantitée des cartes
        private void btnVoirMenu_Click(object sender, EventArgs e)
        {
            foreach(Personnage)
            {

            }
        }
    }
}
