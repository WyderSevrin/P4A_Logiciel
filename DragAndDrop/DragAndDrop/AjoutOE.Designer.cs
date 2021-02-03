namespace DragAndDrop
{
    partial class AjoutOE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutOE));
            this.PanelDD = new System.Windows.Forms.Panel();
            this.LableAuteur = new System.Windows.Forms.Label();
            this.LabelMouvLitt = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelTypeOE = new System.Windows.Forms.Label();
            this.TBAuteur = new System.Windows.Forms.TextBox();
            this.TBGenre = new System.Windows.Forms.TextBox();
            this.CBTypeOE = new System.Windows.Forms.ComboBox();
            this.CBMouvLitt = new System.Windows.Forms.ComboBox();
            this.ButtonValide = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.TBTitre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PanelDD
            // 
            this.PanelDD.AllowDrop = true;
            this.PanelDD.BackColor = System.Drawing.Color.White;
            this.PanelDD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelDD.BackgroundImage")));
            this.PanelDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelDD.Location = new System.Drawing.Point(37, 29);
            this.PanelDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelDD.Name = "PanelDD";
            this.PanelDD.Size = new System.Drawing.Size(451, 265);
            this.PanelDD.TabIndex = 0;
            this.PanelDD.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelDD_DragDrop);
            this.PanelDD.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelDD_DragEnter);
            this.PanelDD.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDD_Paint);
            // 
            // LableAuteur
            // 
            this.LableAuteur.AutoSize = true;
            this.LableAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableAuteur.ForeColor = System.Drawing.Color.Black;
            this.LableAuteur.Location = new System.Drawing.Point(34, 362);
            this.LableAuteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LableAuteur.Name = "LableAuteur";
            this.LableAuteur.Size = new System.Drawing.Size(50, 18);
            this.LableAuteur.TabIndex = 1;
            this.LableAuteur.Text = "Auteur";
            // 
            // LabelMouvLitt
            // 
            this.LabelMouvLitt.AutoSize = true;
            this.LabelMouvLitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMouvLitt.ForeColor = System.Drawing.Color.Black;
            this.LabelMouvLitt.Location = new System.Drawing.Point(271, 348);
            this.LabelMouvLitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMouvLitt.Name = "LabelMouvLitt";
            this.LabelMouvLitt.Size = new System.Drawing.Size(90, 36);
            this.LabelMouvLitt.TabIndex = 2;
            this.LabelMouvLitt.Text = "Mouvement \r\n   littéraire ";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.ForeColor = System.Drawing.Color.Black;
            this.LabelGenre.Location = new System.Drawing.Point(37, 402);
            this.LabelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(49, 18);
            this.LabelGenre.TabIndex = 3;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelTypeOE
            // 
            this.LabelTypeOE.AutoSize = true;
            this.LabelTypeOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeOE.ForeColor = System.Drawing.Color.Black;
            this.LabelTypeOE.Location = new System.Drawing.Point(271, 317);
            this.LabelTypeOE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTypeOE.Name = "LabelTypeOE";
            this.LabelTypeOE.Size = new System.Drawing.Size(97, 18);
            this.LabelTypeOE.TabIndex = 4;
            this.LabelTypeOE.Text = "Type d\'œuvre";
            // 
            // TBAuteur
            // 
            this.TBAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAuteur.Location = new System.Drawing.Point(89, 360);
            this.TBAuteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBAuteur.Name = "TBAuteur";
            this.TBAuteur.Size = new System.Drawing.Size(161, 24);
            this.TBAuteur.TabIndex = 5;
            this.TBAuteur.TextChanged += new System.EventHandler(this.TBAuteur_TextChanged);
            // 
            // TBGenre
            // 
            this.TBGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGenre.Location = new System.Drawing.Point(89, 400);
            this.TBGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBGenre.Name = "TBGenre";
            this.TBGenre.Size = new System.Drawing.Size(161, 24);
            this.TBGenre.TabIndex = 6;
            // 
            // CBTypeOE
            // 
            this.CBTypeOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CBTypeOE.Location = new System.Drawing.Point(375, 315);
            this.CBTypeOE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBTypeOE.Name = "CBTypeOE";
            this.CBTypeOE.Size = new System.Drawing.Size(115, 26);
            this.CBTypeOE.TabIndex = 7;
            // 
            // CBMouvLitt
            // 
            this.CBMouvLitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CBMouvLitt.Location = new System.Drawing.Point(355, 360);
            this.CBMouvLitt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBMouvLitt.Name = "CBMouvLitt";
            this.CBMouvLitt.Size = new System.Drawing.Size(135, 26);
            this.CBMouvLitt.TabIndex = 8;
            // 
            // ButtonValide
            // 
            this.ButtonValide.ForeColor = System.Drawing.Color.Black;
            this.ButtonValide.Location = new System.Drawing.Point(415, 407);
            this.ButtonValide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonValide.Name = "ButtonValide";
            this.ButtonValide.Size = new System.Drawing.Size(73, 24);
            this.ButtonValide.TabIndex = 9;
            this.ButtonValide.Text = "Valider";
            this.ButtonValide.UseVisualStyleBackColor = true;
            this.ButtonValide.Click += new System.EventHandler(this.ButtonValide_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Black;
            this.labelTitre.Location = new System.Drawing.Point(34, 317);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(37, 18);
            this.labelTitre.TabIndex = 10;
            this.labelTitre.Text = "Titre";
            // 
            // TBTitre
            // 
            this.TBTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitre.Location = new System.Drawing.Point(88, 315);
            this.TBTitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBTitre.Name = "TBTitre";
            this.TBTitre.Size = new System.Drawing.Size(161, 24);
            this.TBTitre.TabIndex = 11;
            // 
            // AjoutOE
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.TBTitre);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.ButtonValide);
            this.Controls.Add(this.CBMouvLitt);
            this.Controls.Add(this.CBTypeOE);
            this.Controls.Add(this.TBGenre);
            this.Controls.Add(this.TBAuteur);
            this.Controls.Add(this.LabelTypeOE);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.LabelMouvLitt);
            this.Controls.Add(this.LableAuteur);
            this.Controls.Add(this.PanelDD);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(525, 442);
            this.MinimumSize = new System.Drawing.Size(525, 442);
            this.Name = "AjoutOE";
            this.Size = new System.Drawing.Size(525, 442);
            this.Load += new System.EventHandler(this.AjoutOE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDD;
        private System.Windows.Forms.Label LableAuteur;
        private System.Windows.Forms.Label LabelMouvLitt;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelTypeOE;
        private System.Windows.Forms.TextBox TBAuteur;
        private System.Windows.Forms.TextBox TBGenre;
        private System.Windows.Forms.ComboBox CBTypeOE;
        private System.Windows.Forms.ComboBox CBMouvLitt;
        private System.Windows.Forms.Button ButtonValide;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox TBTitre;
    }
}
