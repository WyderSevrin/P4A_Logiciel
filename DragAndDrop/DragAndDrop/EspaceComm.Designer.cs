namespace DragAndDrop
{
    partial class EspaceComm
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
            this.CheckBUtil = new System.Windows.Forms.CheckBox();
            this.CheckBMsg = new System.Windows.Forms.CheckBox();
            this.LabelFiltre = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CheckBDesComm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckBUtil
            // 
            this.CheckBUtil.AutoSize = true;
            this.CheckBUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBUtil.ForeColor = System.Drawing.Color.Black;
            this.CheckBUtil.Location = new System.Drawing.Point(163, 581);
            this.CheckBUtil.Name = "CheckBUtil";
            this.CheckBUtil.Size = new System.Drawing.Size(159, 56);
            this.CheckBUtil.TabIndex = 1;
            this.CheckBUtil.Text = " Utilisateurs\r\nréprimendés";
            this.CheckBUtil.UseVisualStyleBackColor = true;
            // 
            // CheckBMsg
            // 
            this.CheckBMsg.AutoSize = true;
            this.CheckBMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBMsg.ForeColor = System.Drawing.Color.Black;
            this.CheckBMsg.Location = new System.Drawing.Point(362, 581);
            this.CheckBMsg.Name = "CheckBMsg";
            this.CheckBMsg.Size = new System.Drawing.Size(143, 56);
            this.CheckBMsg.TabIndex = 2;
            this.CheckBMsg.Text = "Messages \r\n signalés";
            this.CheckBMsg.UseVisualStyleBackColor = true;
            // 
            // LabelFiltre
            // 
            this.LabelFiltre.AutoSize = true;
            this.LabelFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltre.ForeColor = System.Drawing.Color.Black;
            this.LabelFiltre.Location = new System.Drawing.Point(49, 595);
            this.LabelFiltre.Name = "LabelFiltre";
            this.LabelFiltre.Size = new System.Drawing.Size(92, 26);
            this.LabelFiltre.TabIndex = 3;
            this.LabelFiltre.Text = "Filtres :";
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 502);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CheckBDesComm
            // 
            this.CheckBDesComm.AutoSize = true;
            this.CheckBDesComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBDesComm.Location = new System.Drawing.Point(603, 581);
            this.CheckBDesComm.Name = "CheckBDesComm";
            this.CheckBDesComm.Size = new System.Drawing.Size(150, 64);
            this.CheckBDesComm.TabIndex = 5;
            this.CheckBDesComm.Text = "Désactiver \r\nEspace \r\nCommentaires";
            this.CheckBDesComm.UseVisualStyleBackColor = true;
            this.CheckBDesComm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EspaceComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.CheckBDesComm);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LabelFiltre);
            this.Controls.Add(this.CheckBMsg);
            this.Controls.Add(this.CheckBUtil);
            this.MaximumSize = new System.Drawing.Size(787, 680);
            this.MinimumSize = new System.Drawing.Size(787, 680);
            this.Name = "EspaceComm";
            this.Size = new System.Drawing.Size(787, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckBUtil;
        private System.Windows.Forms.CheckBox CheckBMsg;
        private System.Windows.Forms.Label LabelFiltre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox CheckBDesComm;
    }
}
