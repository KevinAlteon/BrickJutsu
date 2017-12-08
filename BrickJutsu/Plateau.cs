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
    public partial class Plateau : MetroFramework.Forms.MetroForm
    {
        List<Carte> lc;
        public Plateau()
        {
            InitializeComponent();
            lc = new List<Carte>();
            Personnage p  = new Personnage(1, "Hugo", 11,11,11,11);
            lc.Add(p);
            Personnage p1 = new Personnage(2, "Elodie", 15, 10, 10, 1);
            lc.Add(p1);
            Personnage p2 = new Personnage(3, "Kevin", 5, 10, 10, 5);
            lc.Add(p2);
            Personnage p3 = new Personnage(4, "autruche", 1, 10, 10, 5);
            lc.Add(p3);
            Personnage p4 = new Personnage(5, "poissonchat", 2, 10, 10, 5);
            lc.Add(p4);
            Personnage p5 = new Personnage(6, "citrouille", 3, 10, 10, 5);
            lc.Add(p5);
            Personnage p6 = new Personnage(7, "barbier", 4, 10, 10, 5);
            lc.Add(p6);
            Personnage p7 = new Personnage(8, "limier", 5, 10, 10, 5);
            lc.Add(p7);
            Personnage p8 = new Personnage(9, "Zane", 6, 10, 10, 5);
            lc.Add(p8);
            Personnage p9 = new Personnage(10, "Lloyd", 6, 10, 10, 5);
            lc.Add(p9);
            Personnage p10 = new Personnage(11, "limier", 3, 10, 10, 5);
            lc.Add(p10);
            Personnage p11 = new Personnage(12, "Cole", 2, 10, 10, 5);
            lc.Add(p11);
            Personnage p12 = new Personnage(13, "Kai", 1, 10, 10, 5);
            lc.Add(p12);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ligne et colonne du bouton 
            Button b = sender as Button;
            int c = tableLayoutPanel1.GetColumn(b);
            int l = tableLayoutPanel1.GetRow(b);


            

            //Afficher la main
            string carteChoisie = "";
           
            foreach (RadioButton rdo in Main.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                    
                { 
                    carteChoisie = rdo.Text;
                    rdo.Text = "";
                    break;
                }
            }
             b.Text = carteChoisie;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(retour));
            monthread.Start();
            this.Close();
        }

        public static void retour()
        {
            Application.Run(new Accueil());
        }


        //commencer le tour
        private void CommencerTour_Click(object sender, EventArgs e)
        {
            TerminerTour.Show();
            Main.Show();
            CommencerTour.Hide();
            DebutPartie.Hide();
        }

        //terminer le tour
        private void TerminerTour_Click(object sender, EventArgs e)
        {
            TerminerTour.Hide();
            Main.Hide();
            CommencerTour.Show();
            DebutPartie.Hide();
        }
        
        //Piocher
        private void Piocher_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            foreach (RadioButton rdo in Main.Controls.OfType<RadioButton>())
            {
                if (rdo.Text == "")
                {
                    rdo.Text = lc[ra.Next(lc.Count)].Nom;
                    
                }
            }
        }

        //Défausser
        private void Défausser_Click(object sender, EventArgs e)
        {
            string carteChoisie = "";
            Button b = Défausser;
            foreach (RadioButton rdo in Main.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    carteChoisie = rdo.Text;
                    b.Text = carteChoisie;
                    rdo.Text = "";
                    break;
                }
                
            }
        }
       
        //Début de partie 
        private void DebutPartie_Click(object sender, EventArgs e)
        {
            TerminerTour.Show();
            Main.Show();
            CommencerTour.Show();
            DebutPartie.Hide();

            Random r = new Random();
            int count = 0;
              foreach (RadioButton rdo in Main.Controls.OfType<RadioButton>())
                {
                   if (count< 3)
                     {
                        rdo.Text = lc[r.Next(lc.Count)].Nom;
                        count++;
                     }
             }
        }

    }
}
