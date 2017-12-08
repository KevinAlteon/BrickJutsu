using System;
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
            Collection maCollection = new Collection("Seb");


            String url = "http://localhost/ninjago/public/api"; //là c'est l'adresse de l'api qu'on veut chopper
            var res = new WebClient();  //webClient est utilisable grâce à System.Net
            var json = res.DownloadString(url);             // il existe uploadString aussi (choppe la chaine en json qu'il y a sur l'api)
            JArray o = JArray.Parse(json); //on en fait un tableau

            foreach (var item in o) //pour chaque item dans le JSON
            {
                lstBoxAllCartes.Items.Add(item["nom"].ToString());
                if (item["type"].ToString() == "P")
                {
                    maCollection.ajouterCarte(new Personnage(Convert.ToInt32(item["numero"]), item["nom"].ToString(), Convert.ToInt32(item["attaque"]), Convert.ToInt32(item["defense"]), Convert.ToInt32(item["force"]), Convert.ToInt32(item["vitesse"])));
                }   
            }

            
            string jsonMaCollection = JsonConvert.SerializeObject(maCollection);
            MessageBox.Show(jsonMaCollection);
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

    }
}
