﻿namespace BrickJutsu
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
            this.SuspendLayout();
            // 
            // titreVoirCartes
            // 
            this.titreVoirCartes.ActiveControl = null;
            this.titreVoirCartes.Location = new System.Drawing.Point(23, 24);
            this.titreVoirCartes.Name = "titreVoirCartes";
            this.titreVoirCartes.Size = new System.Drawing.Size(1126, 97);
            this.titreVoirCartes.Style = MetroFramework.MetroColorStyle.Lime;
            this.titreVoirCartes.TabIndex = 0;
            this.titreVoirCartes.Text = "BrickJutsu - Voir les cartes";
            this.titreVoirCartes.UseSelectable = true;
            // 
            // lstBoxAllCartes
            // 
            this.lstBoxAllCartes.FormattingEnabled = true;
            this.lstBoxAllCartes.ItemHeight = 16;
            this.lstBoxAllCartes.Location = new System.Drawing.Point(247, 184);
            this.lstBoxAllCartes.Name = "lstBoxAllCartes";
            this.lstBoxAllCartes.Size = new System.Drawing.Size(654, 308);
            this.lstBoxAllCartes.TabIndex = 1;
            // 
            // buttonVoirLesCartes
            // 
            this.buttonVoirLesCartes.Location = new System.Drawing.Point(515, 127);
            this.buttonVoirLesCartes.Name = "buttonVoirLesCartes";
            this.buttonVoirLesCartes.Size = new System.Drawing.Size(130, 51);
            this.buttonVoirLesCartes.TabIndex = 2;
            this.buttonVoirLesCartes.Text = "Voir les cartes";
            this.buttonVoirLesCartes.UseSelectable = true;
            this.buttonVoirLesCartes.Click += new System.EventHandler(this.buttonVoirLesCartes_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(515, 498);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(130, 51);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseSelectable = true;
            // 
            // VoirLesCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 556);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonVoirLesCartes);
            this.Controls.Add(this.lstBoxAllCartes);
            this.Controls.Add(this.titreVoirCartes);
            this.Name = "VoirLesCartes";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile titreVoirCartes;
        private System.Windows.Forms.ListBox lstBoxAllCartes;
        private MetroFramework.Controls.MetroButton buttonVoirLesCartes;
        private MetroFramework.Controls.MetroButton buttonQuitter;
    }
}
