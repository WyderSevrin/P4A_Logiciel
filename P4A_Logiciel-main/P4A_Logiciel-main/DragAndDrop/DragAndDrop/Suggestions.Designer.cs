namespace DragAndDrop
{
    partial class Suggestions
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
            this.BValider = new System.Windows.Forms.Button();
            this.CheckBBloquer = new System.Windows.Forms.CheckBox();
            this.CheckBAllSugg = new System.Windows.Forms.CheckBox();
            this.CheckBSugg = new System.Windows.Forms.CheckBox();
            this.LabelNomUtil = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BValider);
            this.panel1.Controls.Add(this.CheckBBloquer);
            this.panel1.Controls.Add(this.CheckBAllSugg);
            this.panel1.Controls.Add(this.CheckBSugg);
            this.panel1.Controls.Add(this.LabelNomUtil);
            this.panel1.Location = new System.Drawing.Point(58, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 139);
            this.panel1.TabIndex = 0;
            // 
            // BValider
            // 
            this.BValider.ForeColor = System.Drawing.Color.Black;
            this.BValider.Location = new System.Drawing.Point(563, 20);
            this.BValider.Name = "BValider";
            this.BValider.Size = new System.Drawing.Size(75, 31);
            this.BValider.TabIndex = 4;
            this.BValider.Text = "Valider";
            this.BValider.UseVisualStyleBackColor = true;
            this.BValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBBloquer
            // 
            this.CheckBBloquer.AutoSize = true;
            this.CheckBBloquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBBloquer.ForeColor = System.Drawing.Color.Black;
            this.CheckBBloquer.Location = new System.Drawing.Point(458, 83);
            this.CheckBBloquer.Name = "CheckBBloquer";
            this.CheckBBloquer.Size = new System.Drawing.Size(212, 30);
            this.CheckBBloquer.TabIndex = 3;
            this.CheckBBloquer.Text = "Bloquer utilisateur";
            this.CheckBBloquer.UseVisualStyleBackColor = true;
            // 
            // CheckBAllSugg
            // 
            this.CheckBAllSugg.AutoSize = true;
            this.CheckBAllSugg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBAllSugg.ForeColor = System.Drawing.Color.Black;
            this.CheckBAllSugg.Location = new System.Drawing.Point(209, 70);
            this.CheckBAllSugg.Name = "CheckBAllSugg";
            this.CheckBAllSugg.Size = new System.Drawing.Size(204, 56);
            this.CheckBAllSugg.TabIndex = 2;
            this.CheckBAllSugg.Text = "Supprimer toutes\r\n les suggestions";
            this.CheckBAllSugg.UseVisualStyleBackColor = true;
            // 
            // CheckBSugg
            // 
            this.CheckBSugg.AutoSize = true;
            this.CheckBSugg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBSugg.ForeColor = System.Drawing.Color.Black;
            this.CheckBSugg.Location = new System.Drawing.Point(23, 70);
            this.CheckBSugg.Name = "CheckBSugg";
            this.CheckBSugg.Size = new System.Drawing.Size(162, 56);
            this.CheckBSugg.TabIndex = 1;
            this.CheckBSugg.Text = "Supprimer la\r\n suggestion";
            this.CheckBSugg.UseVisualStyleBackColor = true;
            // 
            // LabelNomUtil
            // 
            this.LabelNomUtil.AutoSize = true;
            this.LabelNomUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomUtil.ForeColor = System.Drawing.Color.Black;
            this.LabelNomUtil.Location = new System.Drawing.Point(18, 17);
            this.LabelNomUtil.Name = "LabelNomUtil";
            this.LabelNomUtil.Size = new System.Drawing.Size(162, 26);
            this.LabelNomUtil.TabIndex = 0;
            this.LabelNomUtil.Text = "Nom Utilisateur";
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(673, 435);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Suggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(787, 680);
            this.MinimumSize = new System.Drawing.Size(787, 680);
            this.Name = "Suggestions";
            this.Size = new System.Drawing.Size(787, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckBBloquer;
        private System.Windows.Forms.CheckBox CheckBAllSugg;
        private System.Windows.Forms.CheckBox CheckBSugg;
        private System.Windows.Forms.Label LabelNomUtil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BValider;
    }
}
