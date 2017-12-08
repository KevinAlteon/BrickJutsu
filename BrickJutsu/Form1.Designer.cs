namespace BrickJutsu
{
    partial class VoirLesCartes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreVoirCartes = new MetroFramework.Controls.MetroTile();
            this.lstBoxAllCartes = new System.Windows.Forms.ListBox();
            this.buttonVoirLesCartes = new MetroFramework.Controls.MetroButton();
            this.buttonQuitter = new MetroFramework.Controls.MetroButton();
            this.voirCartes2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // titreVoirCartes
            // 
            this.titreVoirCartes.ActiveControl = null;
            this.titreVoirCartes.Location = new System.Drawing.Point(17, 20);
            this.titreVoirCartes.Margin = new System.Windows.Forms.Padding(2);
            this.titreVoirCartes.Name = "titreVoirCartes";
            this.titreVoirCartes.Size = new System.Drawing.Size(844, 79);
            this.titreVoirCartes.Style = MetroFramework.MetroColorStyle.Lime;
            this.titreVoirCartes.TabIndex = 0;
            this.titreVoirCartes.Text = "BrickJutsu - Voir les cartes";
            this.titreVoirCartes.UseSelectable = true;
            // 
            // lstBoxAllCartes
            // 
            this.lstBoxAllCartes.FormattingEnabled = true;
            this.lstBoxAllCartes.Location = new System.Drawing.Point(185, 150);
            this.lstBoxAllCartes.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxAllCartes.Name = "lstBoxAllCartes";
            this.lstBoxAllCartes.Size = new System.Drawing.Size(492, 251);
            this.lstBoxAllCartes.TabIndex = 1;
            // 
            // buttonVoirLesCartes
            // 
            this.buttonVoirLesCartes.Location = new System.Drawing.Point(367, 103);
            this.buttonVoirLesCartes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVoirLesCartes.Name = "buttonVoirLesCartes";
            this.buttonVoirLesCartes.Size = new System.Drawing.Size(128, 41);
            this.buttonVoirLesCartes.TabIndex = 2;
            this.buttonVoirLesCartes.Text = "télécharger les cartes";
            this.buttonVoirLesCartes.UseSelectable = true;
            this.buttonVoirLesCartes.Click += new System.EventHandler(this.buttonVoirLesCartes_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(386, 405);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(98, 41);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseSelectable = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // voirCartes2
            // 
            this.voirCartes2.Location = new System.Drawing.Point(499, 103);
            this.voirCartes2.Margin = new System.Windows.Forms.Padding(2);
            this.voirCartes2.Name = "voirCartes2";
            this.voirCartes2.Size = new System.Drawing.Size(98, 41);
            this.voirCartes2.TabIndex = 4;
            this.voirCartes2.Text = "Voir les cartes";
            this.voirCartes2.UseSelectable = true;
            //this.voirCartes2.Click += new System.EventHandler(this.voirCartes2_Click);
            // 
            // VoirLesCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 504);
            this.Controls.Add(this.voirCartes2);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonVoirLesCartes);
            this.Controls.Add(this.lstBoxAllCartes);
            this.Controls.Add(this.titreVoirCartes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VoirLesCartes";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile titreVoirCartes;
        private System.Windows.Forms.ListBox lstBoxAllCartes;
        private MetroFramework.Controls.MetroButton buttonVoirLesCartes;
        private MetroFramework.Controls.MetroButton buttonQuitter;
        private MetroFramework.Controls.MetroButton voirCartes2;
    }
}

