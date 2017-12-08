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
        private int nbJ11;
        private int nbJ12;

        public InstanceJoueur()
        {
            InitializeComponent();
            Relancer.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Joueur j = new Joueur(Joueur.Text);
            Joueur j1 = new Joueur(Joueur1.Text);
            
            if (this.nbJ1 > this.nbJ2)
            {
                MessageBox.Show(j.Nom + " commence la partie ! ");
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
                monthread.Start();
                this.Close();
            }
            else if (this.nbJ1 == this.nbJ2)
            {
                Relancer.Show();
            }
            else if (this.nbJ1 < this.nbJ2)
            {
                MessageBox.Show(j1.Nom +" commence la partie ! ");
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
                monthread.Start();
                this.Close();
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
            int de1 = alea.Next(1, 7);
            resultatj1.Text = de1.ToString();
            this.nbJ1 = de1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int de2 = alea.Next(1, 7);
            resultatj2.Text = de2.ToString();
            this.nbJ2 = de2;
        }

        private void Relancer_Click(object sender, EventArgs e)
        {
            Joueur j = new Joueur(Joueur.Text);
            Joueur j1 = new Joueur(Joueur1.Text);

            Random alea = new Random();
            int de2 = alea.Next(1, 7);
            resultatj2.Text = de2.ToString();
            this.nbJ12 = de2;

            Random aleat = new Random();
            int de1 = aleat.Next(1, 7);
            resultatj1.Text = de1.ToString();
            this.nbJ11 = de1;

            if (this.nbJ11 > this.nbJ12)
            {
                MessageBox.Show(j.Nom + " commence la partie ! ");
            }
            else
            {
                MessageBox.Show(j1.Nom + " commence la partie ! ");
            }
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
            monthread.Start();
            this.Close();
        }
    }
}
