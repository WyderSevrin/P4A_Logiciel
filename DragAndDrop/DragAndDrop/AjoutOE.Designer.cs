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
            this.SuspendLayout();
            // 
            // PanelDD
            // 
            this.PanelDD.AllowDrop = true;
            this.PanelDD.BackColor = System.Drawing.Color.White;
            this.PanelDD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelDD.BackgroundImage")));
            this.PanelDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelDD.Location = new System.Drawing.Point(56, 45);
            this.PanelDD.Name = "PanelDD";
            this.PanelDD.Size = new System.Drawing.Size(676, 408);
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
            this.LableAuteur.Location = new System.Drawing.Point(51, 488);
            this.LableAuteur.Name = "LableAuteur";
            this.LableAuteur.Size = new System.Drawing.Size(76, 26);
            this.LableAuteur.TabIndex = 1;
            this.LableAuteur.Text = "Auteur";
            // 
            // LabelMouvLitt
            // 
            this.LabelMouvLitt.AutoSize = true;
            this.LabelMouvLitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMouvLitt.ForeColor = System.Drawing.Color.Black;
            this.LabelMouvLitt.Location = new System.Drawing.Point(406, 560);
            this.LabelMouvLitt.Name = "LabelMouvLitt";
            this.LabelMouvLitt.Size = new System.Drawing.Size(132, 52);
            this.LabelMouvLitt.TabIndex = 2;
            this.LabelMouvLitt.Text = "Mouvement \r\n   littéraire ";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.ForeColor = System.Drawing.Color.Black;
            this.LabelGenre.Location = new System.Drawing.Point(406, 488);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(72, 26);
            this.LabelGenre.TabIndex = 3;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelTypeOE
            // 
            this.LabelTypeOE.AutoSize = true;
            this.LabelTypeOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeOE.ForeColor = System.Drawing.Color.Black;
            this.LabelTypeOE.Location = new System.Drawing.Point(51, 569);
            this.LabelTypeOE.Name = "LabelTypeOE";
            this.LabelTypeOE.Size = new System.Drawing.Size(144, 26);
            this.LabelTypeOE.TabIndex = 4;
            this.LabelTypeOE.Text = "Type d\'œuvre";
            // 
            // TBAuteur
            // 
            this.TBAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAuteur.Location = new System.Drawing.Point(133, 485);
            this.TBAuteur.Name = "TBAuteur";
            this.TBAuteur.Size = new System.Drawing.Size(239, 32);
            this.TBAuteur.TabIndex = 5;
            this.TBAuteur.TextChanged += new System.EventHandler(this.TBAuteur_TextChanged);
            // 
            // TBGenre
            // 
            this.TBGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGenre.Location = new System.Drawing.Point(484, 485);
            this.TBGenre.Name = "TBGenre";
            this.TBGenre.Size = new System.Drawing.Size(248, 32);
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
            this.CBTypeOE.Location = new System.Drawing.Point(201, 566);
            this.CBTypeOE.Name = "CBTypeOE";
            this.CBTypeOE.Size = new System.Drawing.Size(170, 34);
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
            this.CBMouvLitt.Location = new System.Drawing.Point(532, 566);
            this.CBMouvLitt.Name = "CBMouvLitt";
            this.CBMouvLitt.Size = new System.Drawing.Size(200, 34);
            this.CBMouvLitt.TabIndex = 8;
            // 
            // ButtonValide
            // 
            this.ButtonValide.ForeColor = System.Drawing.Color.Black;
            this.ButtonValide.Location = new System.Drawing.Point(622, 626);
            this.ButtonValide.Name = "ButtonValide";
            this.ButtonValide.Size = new System.Drawing.Size(110, 37);
            this.ButtonValide.TabIndex = 9;
            this.ButtonValide.Text = "Valider";
            this.ButtonValide.UseVisualStyleBackColor = true;
            this.ButtonValide.Click += new System.EventHandler(this.ButtonValide_Click);
            // 
            // AjoutOE
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
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
            this.MaximumSize = new System.Drawing.Size(787, 680);
            this.MinimumSize = new System.Drawing.Size(787, 680);
            this.Name = "AjoutOE";
            this.Size = new System.Drawing.Size(787, 680);
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
    }
}
