namespace DragAndDrop
{
    partial class GererBiblio
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelFiltre = new System.Windows.Forms.Label();
            this.CBMouvLittFiltre = new System.Windows.Forms.ComboBox();
            this.CBTypeOEFiltre = new System.Windows.Forms.ComboBox();
            this.LabelMouvLittFiltre = new System.Windows.Forms.Label();
            this.LabelTypeOEFiltre = new System.Windows.Forms.Label();
            this.CheckBAlpha = new System.Windows.Forms.CheckBox();
            this.CheckBAjout = new System.Windows.Forms.CheckBox();
            this.LabelTitre = new System.Windows.Forms.Label();
            this.LabelAuteur = new System.Windows.Forms.Label();
            this.LabelTypeOE = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelMouvLitt = new System.Windows.Forms.Label();
            this.TBTitre = new System.Windows.Forms.TextBox();
            this.TBAuteur = new System.Windows.Forms.TextBox();
            this.TBGenre = new System.Windows.Forms.TextBox();
            this.CBTypeOE = new System.Windows.Forms.ComboBox();
            this.CBMouvLitt = new System.Windows.Forms.ComboBox();
            this.ButtonModif = new System.Windows.Forms.Button();
            this.ButtonSuppr = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelFiltre);
            this.panel1.Controls.Add(this.CBMouvLittFiltre);
            this.panel1.Controls.Add(this.CBTypeOEFiltre);
            this.panel1.Controls.Add(this.LabelMouvLittFiltre);
            this.panel1.Controls.Add(this.LabelTypeOEFiltre);
            this.panel1.Controls.Add(this.CheckBAlpha);
            this.panel1.Controls.Add(this.CheckBAjout);
            this.panel1.Location = new System.Drawing.Point(43, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 165);
            this.panel1.TabIndex = 1;
            // 
            // LabelFiltre
            // 
            this.LabelFiltre.AutoSize = true;
            this.LabelFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltre.ForeColor = System.Drawing.Color.Black;
            this.LabelFiltre.Location = new System.Drawing.Point(15, 20);
            this.LabelFiltre.Name = "LabelFiltre";
            this.LabelFiltre.Size = new System.Drawing.Size(78, 26);
            this.LabelFiltre.TabIndex = 6;
            this.LabelFiltre.Text = "Filtres";
            // 
            // CBMouvLittFiltre
            // 
            this.CBMouvLittFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMouvLittFiltre.ForeColor = System.Drawing.Color.Black;
            this.CBMouvLittFiltre.FormattingEnabled = true;
            this.CBMouvLittFiltre.Items.AddRange(new object[] {
            "",
            "Humanisme",
            "Baroque",
            "Lumières",
            "Romantisme",
            "Réalisme",
            "Symbolisme",
            "Surréalisme"});
            this.CBMouvLittFiltre.Location = new System.Drawing.Point(470, 113);
            this.CBMouvLittFiltre.Name = "CBMouvLittFiltre";
            this.CBMouvLittFiltre.Size = new System.Drawing.Size(209, 34);
            this.CBMouvLittFiltre.TabIndex = 5;
            // 
            // CBTypeOEFiltre
            // 
            this.CBTypeOEFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTypeOEFiltre.ForeColor = System.Drawing.Color.Black;
            this.CBTypeOEFiltre.FormattingEnabled = true;
            this.CBTypeOEFiltre.Items.AddRange(new object[] {
            "",
            "Article de presse",
            "Autobiographie",
            "Conte",
            "Historique",
            "Nouvelle",
            "Poésie",
            "Revue de cuisine",
            "Recueil de chants",
            "Roman",
            "Théâtre"});
            this.CBTypeOEFiltre.Location = new System.Drawing.Point(470, 59);
            this.CBTypeOEFiltre.Name = "CBTypeOEFiltre";
            this.CBTypeOEFiltre.Size = new System.Drawing.Size(209, 34);
            this.CBTypeOEFiltre.TabIndex = 4;
            // 
            // LabelMouvLittFiltre
            // 
            this.LabelMouvLittFiltre.AutoSize = true;
            this.LabelMouvLittFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMouvLittFiltre.ForeColor = System.Drawing.Color.Black;
            this.LabelMouvLittFiltre.Location = new System.Drawing.Point(255, 117);
            this.LabelMouvLittFiltre.Name = "LabelMouvLittFiltre";
            this.LabelMouvLittFiltre.Size = new System.Drawing.Size(209, 26);
            this.LabelMouvLittFiltre.TabIndex = 3;
            this.LabelMouvLittFiltre.Text = "Mouvement littéraire";
            // 
            // LabelTypeOEFiltre
            // 
            this.LabelTypeOEFiltre.AutoSize = true;
            this.LabelTypeOEFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeOEFiltre.ForeColor = System.Drawing.Color.Black;
            this.LabelTypeOEFiltre.Location = new System.Drawing.Point(320, 67);
            this.LabelTypeOEFiltre.Name = "LabelTypeOEFiltre";
            this.LabelTypeOEFiltre.Size = new System.Drawing.Size(144, 26);
            this.LabelTypeOEFiltre.TabIndex = 2;
            this.LabelTypeOEFiltre.Text = "Type d\'œuvre";
            // 
            // CheckBAlpha
            // 
            this.CheckBAlpha.AutoSize = true;
            this.CheckBAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBAlpha.ForeColor = System.Drawing.Color.Black;
            this.CheckBAlpha.Location = new System.Drawing.Point(15, 66);
            this.CheckBAlpha.Name = "CheckBAlpha";
            this.CheckBAlpha.Size = new System.Drawing.Size(223, 30);
            this.CheckBAlpha.TabIndex = 1;
            this.CheckBAlpha.Text = "Ordre alphabétique";
            this.CheckBAlpha.UseVisualStyleBackColor = true;
            // 
            // CheckBAjout
            // 
            this.CheckBAjout.AutoSize = true;
            this.CheckBAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBAjout.ForeColor = System.Drawing.Color.Black;
            this.CheckBAjout.Location = new System.Drawing.Point(15, 117);
            this.CheckBAjout.Name = "CheckBAjout";
            this.CheckBAjout.Size = new System.Drawing.Size(153, 30);
            this.CheckBAjout.TabIndex = 0;
            this.CheckBAjout.Text = "Date d\'ajout";
            this.CheckBAjout.UseVisualStyleBackColor = true;
            // 
            // LabelTitre
            // 
            this.LabelTitre.AutoSize = true;
            this.LabelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitre.ForeColor = System.Drawing.Color.Black;
            this.LabelTitre.Location = new System.Drawing.Point(453, 46);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(54, 26);
            this.LabelTitre.TabIndex = 2;
            this.LabelTitre.Text = "Titre";
            // 
            // LabelAuteur
            // 
            this.LabelAuteur.AutoSize = true;
            this.LabelAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAuteur.ForeColor = System.Drawing.Color.Black;
            this.LabelAuteur.Location = new System.Drawing.Point(453, 121);
            this.LabelAuteur.Name = "LabelAuteur";
            this.LabelAuteur.Size = new System.Drawing.Size(76, 26);
            this.LabelAuteur.TabIndex = 3;
            this.LabelAuteur.Text = "Auteur";
            // 
            // LabelTypeOE
            // 
            this.LabelTypeOE.AutoSize = true;
            this.LabelTypeOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeOE.ForeColor = System.Drawing.Color.Black;
            this.LabelTypeOE.Location = new System.Drawing.Point(453, 186);
            this.LabelTypeOE.Name = "LabelTypeOE";
            this.LabelTypeOE.Size = new System.Drawing.Size(91, 52);
            this.LabelTypeOE.TabIndex = 4;
            this.LabelTypeOE.Text = "  Type \r\nd\'œuvre";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.ForeColor = System.Drawing.Color.Black;
            this.LabelGenre.Location = new System.Drawing.Point(453, 277);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(72, 26);
            this.LabelGenre.TabIndex = 5;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelMouvLitt
            // 
            this.LabelMouvLitt.AutoSize = true;
            this.LabelMouvLitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMouvLitt.ForeColor = System.Drawing.Color.Black;
            this.LabelMouvLitt.Location = new System.Drawing.Point(453, 337);
            this.LabelMouvLitt.Name = "LabelMouvLitt";
            this.LabelMouvLitt.Size = new System.Drawing.Size(126, 52);
            this.LabelMouvLitt.TabIndex = 6;
            this.LabelMouvLitt.Text = "Mouvement\r\n   littéraire";
            // 
            // TBTitre
            // 
            this.TBTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitre.ForeColor = System.Drawing.Color.Black;
            this.TBTitre.Location = new System.Drawing.Point(514, 46);
            this.TBTitre.Name = "TBTitre";
            this.TBTitre.Size = new System.Drawing.Size(227, 32);
            this.TBTitre.TabIndex = 7;
            // 
            // TBAuteur
            // 
            this.TBAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAuteur.ForeColor = System.Drawing.Color.Black;
            this.TBAuteur.Location = new System.Drawing.Point(536, 118);
            this.TBAuteur.Name = "TBAuteur";
            this.TBAuteur.Size = new System.Drawing.Size(205, 32);
            this.TBAuteur.TabIndex = 8;
            // 
            // TBGenre
            // 
            this.TBGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGenre.ForeColor = System.Drawing.Color.Black;
            this.TBGenre.Location = new System.Drawing.Point(532, 274);
            this.TBGenre.Name = "TBGenre";
            this.TBGenre.Size = new System.Drawing.Size(209, 32);
            this.TBGenre.TabIndex = 9;
            // 
            // CBTypeOE
            // 
            this.CBTypeOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTypeOE.ForeColor = System.Drawing.Color.Black;
            this.CBTypeOE.FormattingEnabled = true;
            this.CBTypeOE.Items.AddRange(new object[] {
            "",
            "Article de presse",
            "Autobiographie",
            "Conte",
            "Historique",
            "Nouvelle",
            "Poésie",
            "Revue de cuisine",
            "Recueil de chants",
            "Roman",
            "Théâtre"});
            this.CBTypeOE.Location = new System.Drawing.Point(551, 195);
            this.CBTypeOE.Name = "CBTypeOE";
            this.CBTypeOE.Size = new System.Drawing.Size(190, 34);
            this.CBTypeOE.TabIndex = 10;
            // 
            // CBMouvLitt
            // 
            this.CBMouvLitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMouvLitt.ForeColor = System.Drawing.Color.Black;
            this.CBMouvLitt.FormattingEnabled = true;
            this.CBMouvLitt.Items.AddRange(new object[] {
            "",
            "Humanisme",
            "Baroque",
            "Lumières",
            "Romantisme",
            "Réalisme",
            "Symbolisme",
            "Surréalisme"});
            this.CBMouvLitt.Location = new System.Drawing.Point(586, 346);
            this.CBMouvLitt.Name = "CBMouvLitt";
            this.CBMouvLitt.Size = new System.Drawing.Size(155, 34);
            this.CBMouvLitt.TabIndex = 11;
            // 
            // ButtonModif
            // 
            this.ButtonModif.ForeColor = System.Drawing.Color.Black;
            this.ButtonModif.Location = new System.Drawing.Point(631, 410);
            this.ButtonModif.Name = "ButtonModif";
            this.ButtonModif.Size = new System.Drawing.Size(110, 44);
            this.ButtonModif.TabIndex = 12;
            this.ButtonModif.Text = "Modifier";
            this.ButtonModif.UseVisualStyleBackColor = true;
            this.ButtonModif.Click += new System.EventHandler(this.ButtonModif_Click);
            // 
            // ButtonSuppr
            // 
            this.ButtonSuppr.ForeColor = System.Drawing.Color.Black;
            this.ButtonSuppr.Location = new System.Drawing.Point(458, 410);
            this.ButtonSuppr.Name = "ButtonSuppr";
            this.ButtonSuppr.Size = new System.Drawing.Size(110, 44);
            this.ButtonSuppr.TabIndex = 13;
            this.ButtonSuppr.Text = "Supprimer";
            this.ButtonSuppr.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 408);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // GererBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButtonSuppr);
            this.Controls.Add(this.ButtonModif);
            this.Controls.Add(this.CBMouvLitt);
            this.Controls.Add(this.CBTypeOE);
            this.Controls.Add(this.TBGenre);
            this.Controls.Add(this.TBAuteur);
            this.Controls.Add(this.TBTitre);
            this.Controls.Add(this.LabelMouvLitt);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.LabelTypeOE);
            this.Controls.Add(this.LabelAuteur);
            this.Controls.Add(this.LabelTitre);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(787, 680);
            this.MinimumSize = new System.Drawing.Size(787, 680);
            this.Name = "GererBiblio";
            this.Size = new System.Drawing.Size(787, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.Label LabelAuteur;
        private System.Windows.Forms.Label LabelTypeOE;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelMouvLitt;
        private System.Windows.Forms.TextBox TBTitre;
        private System.Windows.Forms.TextBox TBAuteur;
        private System.Windows.Forms.TextBox TBGenre;
        private System.Windows.Forms.ComboBox CBTypeOE;
        private System.Windows.Forms.ComboBox CBMouvLitt;
        private System.Windows.Forms.Button ButtonModif;
        private System.Windows.Forms.Button ButtonSuppr;
        private System.Windows.Forms.Label LabelFiltre;
        private System.Windows.Forms.ComboBox CBMouvLittFiltre;
        private System.Windows.Forms.ComboBox CBTypeOEFiltre;
        private System.Windows.Forms.Label LabelMouvLittFiltre;
        private System.Windows.Forms.Label LabelTypeOEFiltre;
        private System.Windows.Forms.CheckBox CheckBAlpha;
        private System.Windows.Forms.CheckBox CheckBAjout;
        private System.Windows.Forms.ListView listView1;
    }
}
