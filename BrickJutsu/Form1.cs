﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace BrickJutsu
{
    public partial class VoirLesCartes : MetroFramework.Forms.MetroForm
    {
        public VoirLesCartes()
        {
            InitializeComponent();
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "persos.json")))
            {
                voirCartes2.Visible = true;
                buttonVoirLesCartes.Visible = false;
            }
            else
            {
                voirCartes2.Visible = false;
                buttonVoirLesCartes.Visible = true;
            }
        }

        private void buttonVoirLesCartes_Click(object sender, EventArgs e)
        {
            Collection maCollection = new Collection("Seb");


            String url = "http://localhost/ninjago/public/api"; //là c'est l'adresse de l'api qu'on veut chopper
            var res = new WebClient();  //webClient est utilisable grâce à System.Net
            var json = res.DownloadString(url); // il existe uploadString aussi (choppe la chaine en json qu'il y a sur l'api)
            JArray o = JArray.Parse(json); //on en fait un tableau

            foreach (var item in o) //pour chaque item dans le JSON
            {
                if (item["type"].ToString() == "P")
                {
                    maCollection.ajouterCarte(new Personnage(item["numero"].ToString(), item["nom"].ToString(), Convert.ToInt32(item["attaque"]), Convert.ToInt32(item["defense"]), Convert.ToInt32(item["force"]), Convert.ToInt32(item["vitesse"])));
                }
                MessageBox.Show("Succès. Les cartes sont téléchargées dans l'application.");
            }
            File.WriteAllText("persos.json", JsonConvert.SerializeObject(maCollection, Formatting.Indented));
        }

        //bouton retour
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(retour));
            monthread.Start();
            this.Close();
        }

        public static void retour()
        {
            Application.Run(new Accueil());
        }

        private void voirCartes2_Click(object sender, EventArgs e)
        {
            var mdr = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("persos.json"));
            foreach (var item in mdr)
            {
                lstBoxAllCartes.Items.Add(item.Nom.ToString());
            }
        }
    }
}
