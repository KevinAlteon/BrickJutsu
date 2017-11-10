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
        public Plateau()
        {
            InitializeComponent();
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
                else
                {
                    MessageBox.Show("Vous ne pouvez pas piocher de carte sans vous défausser ou attendre le tour suivant");
                    break;
                }
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
