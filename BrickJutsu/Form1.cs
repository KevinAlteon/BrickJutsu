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

namespace BrickJutsu
{
    public partial class VoirLesCartes : MetroFramework.Forms.MetroForm
    {
        public VoirLesCartes()
        {
            InitializeComponent();
        }

        private void buttonVoirLesCartes_Click(object sender, EventArgs e)
        {
            Collection maCollection = new Collection("Seb", DateTime.Now);


            String url = "http://localhost/ninjago/public/api"; //là c'est l'adresse de l'api qu'on veut chopper
            var res = new WebClient();  //webClient est utilisable grâce à System.Net
            var json = res.DownloadString(url);             // il existe uploadString aussi (choppe la chaine en json qu'il y a sur l'api)
            JArray o = JArray.Parse(json); //on en fait un tableau

            foreach (var item in o) //pour chaque item dans le JSON
            {
                lstBoxAllCartes.Items.Add(item["nom"].ToString());
                maCollection.ajouterCarte(new Carte(item["nom"].ToString(), Convert.ToInt32(item["numero"])));

            }

            
            string newjson = JsonConvert.SerializeObject(maCollection);
            MessageBox.Show(newjson);
        }
    }
}