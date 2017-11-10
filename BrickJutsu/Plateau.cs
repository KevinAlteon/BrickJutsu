﻿using System;
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

        private void button13_Click(object sender, EventArgs e)
        {
            button10.Show();
            Main.Show();
            button13.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            Main.Hide();
            button13.Show();
        }
    }
}
