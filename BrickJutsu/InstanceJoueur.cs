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
    public partial class InstanceJoueur : MetroFramework.Forms.MetroForm
    {
        private int nbJ1;
        private int nbJ2;
        
        public InstanceJoueur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
            monthread.Start();
            this.Close();
            Joueur j = new Joueur(Joueur.ToString());
            Joueur j1 = new Joueur(Joueur1.ToString());
            if (this.nbJ1 > this.nbJ2)
            {
                MessageBox.Show(j + " commence la partie ! ");
            }
            else
            {
                MessageBox.Show(j1 + " commence la partie ! ");
            }
        }

        public static void jouer()
        {
            Application.Run(new Plateau());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(retour));
            monthread.Start();
            this.Close();
        }

        public static void retour()
        {
            Application.Run(new Accueil());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int dé1 = alea.Next(1, 7);
            resultatj1.Text = dé1.ToString();
            this.nbJ1 = dé1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int dé2 = alea.Next(1, 7);
            resultatj2.Text = dé2.ToString();
            this.nbJ2 = dé2;
        }
    }
}
