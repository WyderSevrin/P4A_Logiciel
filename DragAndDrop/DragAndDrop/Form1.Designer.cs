namespace DragAndDrop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonSugg = new System.Windows.Forms.Button();
            this.ButtonEspComm = new System.Windows.Forms.Button();
            this.ButtonBiblio = new System.Windows.Forms.Button();
            this.ButtonAjoutOE = new System.Windows.Forms.Button();
            this.PanelOrange = new System.Windows.Forms.Panel();
            this.suggestions1 = new DragAndDrop.Suggestions();
            this.espaceComm1 = new DragAndDrop.EspaceComm();
            this.gererBiblio1 = new DragAndDrop.GererBiblio();
            this.ajoutOE1 = new DragAndDrop.AjoutOE();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.ButtonPower);
            this.PanelMenu.Controls.Add(this.ButtonSugg);
            this.PanelMenu.Controls.Add(this.ButtonEspComm);
            this.PanelMenu.Controls.Add(this.ButtonBiblio);
            this.PanelMenu.Controls.Add(this.ButtonAjoutOE);
            this.PanelMenu.Location = new System.Drawing.Point(0, -1);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(168, 452);
            this.PanelMenu.TabIndex = 0;
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPower.BackgroundImage")));
            this.ButtonPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPower.Location = new System.Drawing.Point(9, 410);
            this.ButtonPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(39, 36);
            this.ButtonPower.TabIndex = 4;
            this.ButtonPower.UseVisualStyleBackColor = true;
            this.ButtonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // ButtonSugg
            // 
            this.ButtonSugg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSugg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSugg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSugg.Location = new System.Drawing.Point(-5, 230);
            this.ButtonSugg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSugg.Name = "ButtonSugg";
            this.ButtonSugg.Size = new System.Drawing.Size(180, 47);
            this.ButtonSugg.TabIndex = 3;
            this.ButtonSugg.Text = "     Suggestions lecteurs";
            this.ButtonSugg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSugg.UseVisualStyleBackColor = true;
            this.ButtonSugg.Click += new System.EventHandler(this.ButtonSugg_Click);
            // 
            // ButtonEspComm
            // 
            this.ButtonEspComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEspComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEspComm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEspComm.Location = new System.Drawing.Point(-5, 185);
            this.ButtonEspComm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEspComm.Name = "ButtonEspComm";
            this.ButtonEspComm.Size = new System.Drawing.Size(180, 47);
            this.ButtonEspComm.TabIndex = 2;
            this.ButtonEspComm.Text = "     Espace commentaires";
            this.ButtonEspComm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEspComm.UseVisualStyleBackColor = true;
            this.ButtonEspComm.Click += new System.EventHandler(this.ButtonEspComm_Click);
            // 
            // ButtonBiblio
            // 
            this.ButtonBiblio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBiblio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonBiblio.Location = new System.Drawing.Point(-5, 141);
            this.ButtonBiblio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBiblio.Name = "ButtonBiblio";
            this.ButtonBiblio.Size = new System.Drawing.Size(180, 47);
            this.ButtonBiblio.TabIndex = 1;
            this.ButtonBiblio.Text = "     Gérer la bibliothèque";
            this.ButtonBiblio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBiblio.UseVisualStyleBackColor = true;
            this.ButtonBiblio.Click += new System.EventHandler(this.ButtonBiblio_Click);
            // 
            // ButtonAjoutOE
            // 
            this.ButtonAjoutOE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAjoutOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAjoutOE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAjoutOE.Location = new System.Drawing.Point(-5, 97);
            this.ButtonAjoutOE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAjoutOE.Name = "ButtonAjoutOE";
            this.ButtonAjoutOE.Size = new System.Drawing.Size(180, 47);
            this.ButtonAjoutOE.TabIndex = 0;
            this.ButtonAjoutOE.Text = "     Ajouter une œuvre";
            this.ButtonAjoutOE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAjoutOE.UseVisualStyleBackColor = true;
            this.ButtonAjoutOE.Click += new System.EventHandler(this.ButtonAjoutOE_Click);
            // 
            // PanelOrange
            // 
            this.PanelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(16)))));
            this.PanelOrange.Location = new System.Drawing.Point(167, -1);
            this.PanelOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelOrange.Name = "PanelOrange";
            this.PanelOrange.Size = new System.Drawing.Size(527, 21);
            this.PanelOrange.TabIndex = 1;
            // 
            // suggestions1
            // 
            this.suggestions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.suggestions1.Location = new System.Drawing.Point(167, 18);
            this.suggestions1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.suggestions1.MaximumSize = new System.Drawing.Size(525, 442);
            this.suggestions1.MinimumSize = new System.Drawing.Size(525, 442);
            this.suggestions1.Name = "suggestions1";
            this.suggestions1.Size = new System.Drawing.Size(525, 442);
            this.suggestions1.TabIndex = 2;
            // 
            // espaceComm1
            // 
            this.espaceComm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.espaceComm1.Location = new System.Drawing.Point(167, 18);
            this.espaceComm1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.espaceComm1.MaximumSize = new System.Drawing.Size(525, 442);
            this.espaceComm1.MinimumSize = new System.Drawing.Size(525, 442);
            this.espaceComm1.Name = "espaceComm1";
            this.espaceComm1.Size = new System.Drawing.Size(525, 442);
            this.espaceComm1.TabIndex = 3;
            // 
            // gererBiblio1
            // 
            this.gererBiblio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.gererBiblio1.Location = new System.Drawing.Point(167, 18);
            this.gererBiblio1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gererBiblio1.MaximumSize = new System.Drawing.Size(525, 442);
            this.gererBiblio1.MinimumSize = new System.Drawing.Size(525, 442);
            this.gererBiblio1.Name = "gererBiblio1";
            this.gererBiblio1.Size = new System.Drawing.Size(525, 442);
            this.gererBiblio1.TabIndex = 4;
            // 
            // ajoutOE1
            // 
            this.ajoutOE1.AllowDrop = true;
            this.ajoutOE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.ajoutOE1.Location = new System.Drawing.Point(167, 18);
            this.ajoutOE1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ajoutOE1.MaximumSize = new System.Drawing.Size(525, 442);
            this.ajoutOE1.MinimumSize = new System.Drawing.Size(525, 442);
            this.ajoutOE1.Name = "ajoutOE1";
            this.ajoutOE1.Size = new System.Drawing.Size(525, 442);
            this.ajoutOE1.TabIndex = 5;
            this.ajoutOE1.Load += new System.EventHandler(this.ajoutOE1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 453);
            this.Controls.Add(this.ajoutOE1);
            this.Controls.Add(this.gererBiblio1);
            this.Controls.Add(this.espaceComm1);
            this.Controls.Add(this.suggestions1);
            this.Controls.Add(this.PanelOrange);
            this.Controls.Add(this.PanelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelOrange;
        private System.Windows.Forms.Button ButtonSugg;
        private System.Windows.Forms.Button ButtonEspComm;
        private System.Windows.Forms.Button ButtonBiblio;
        private System.Windows.Forms.Button ButtonAjoutOE;
        public System.Windows.Forms.Button ButtonPower;
        private Suggestions suggestions1;
        private EspaceComm espaceComm1;
        private GererBiblio gererBiblio1;
        private AjoutOE ajoutOE1;
    }
}

