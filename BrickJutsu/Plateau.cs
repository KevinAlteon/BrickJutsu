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
            Personnage p = new Personnage(1, "hugo", 11,11,11,11);
            lc.Add(p);
            Personnage p1 = new Personnage(2, "elodie", 15, 10, 10, 1);
            lc.Add(p1);
            Personnage p2 = new Personnage(3, "kevin", 5, 10, 10, 5);
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
        private void button13_Click(object sender, EventArgs e)
        {
            button10.Show();
            Main.Show();
            button13.Hide();
        }

        //terminer le tour
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            Main.Hide();
            button13.Show();
        }

        //Piocher
        private void button12_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in Main.Controls.OfType<RadioButton>())
            {
                if (rdo.Text.Equals(""))
                {
                    rdo.Text = "Jay";
                    break;
                }
                //else
                //{
                  //  MessageBox.Show("Vous ne pouvez pas piocher de carte sans vous défausser ou attendre le tour suivant");
                    //break;
                //}
            }
        }

        //Défausser
        private void button11_Click(object sender, EventArgs e)
        {
            string carteChoisie = "";
            Button b = button11;
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
    }
}
