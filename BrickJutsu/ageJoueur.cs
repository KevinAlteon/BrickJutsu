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
    public partial class ageJoueur : MetroFramework.Forms.MetroForm
    {
        public ageJoueur()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);
        }

        private void button1_Click(object sender, EventArgs e)        
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(jouer));
            monthread.Start();
            this.Close();
        }

        public static void jouer()
        {
            Application.Run(new Plateau());
        }

        
    }
}

