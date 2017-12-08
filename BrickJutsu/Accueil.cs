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
    public partial class Accueil : MetroFramework.Forms.MetroForm
    {
        public Accueil()
        {
            InitializeComponent();


            //coucou
        }

        //plateau
        private void metroButton5_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
            monthread.Start();
            this.Close();
        }

        public static void jouer()
        {
            Application.Run(new InstanceJoueur());
        }

        //gestion collection
        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(gestionCollection));
            monthread.Start();
            this.Close();
        }

        public static void gestionCollection()
        {
            Application.Run(new VoirLesCartes());
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DialogResult retour = MessageBox.Show("Voulez vraiment quitter le jeu ? ", "Attention !", MessageBoxButtons.YesNoCancel);
            if (retour == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}