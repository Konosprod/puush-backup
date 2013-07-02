namespace WindowsFormsApplication3
{
    partial class mainWindow
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLaClefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxPublic = new System.Windows.Forms.CheckBox();
            this.checkBoxPrivate = new System.Windows.Forms.CheckBox();
            this.checkBoxGallery = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Télécharger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerLaClefToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // editerLaClefToolStripMenuItem
            // 
            this.editerLaClefToolStripMenuItem.Name = "editerLaClefToolStripMenuItem";
            this.editerLaClefToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editerLaClefToolStripMenuItem.Text = "Editer la clef";
            this.editerLaClefToolStripMenuItem.Click += new System.EventHandler(this.editerLaClefToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dossier de sortie :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxPublic
            // 
            this.checkBoxPublic.AutoSize = true;
            this.checkBoxPublic.Checked = true;
            this.checkBoxPublic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPublic.Location = new System.Drawing.Point(129, 76);
            this.checkBoxPublic.Name = "checkBoxPublic";
            this.checkBoxPublic.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPublic.TabIndex = 9;
            this.checkBoxPublic.Text = "Public";
            this.checkBoxPublic.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrivate
            // 
            this.checkBoxPrivate.AutoSize = true;
            this.checkBoxPrivate.Location = new System.Drawing.Point(129, 100);
            this.checkBoxPrivate.Name = "checkBoxPrivate";
            this.checkBoxPrivate.Size = new System.Drawing.Size(50, 17);
            this.checkBoxPrivate.TabIndex = 10;
            this.checkBoxPrivate.Text = "Privé";
            this.checkBoxPrivate.UseVisualStyleBackColor = true;
            // 
            // checkBoxGallery
            // 
            this.checkBoxGallery.AutoSize = true;
            this.checkBoxGallery.Location = new System.Drawing.Point(129, 124);
            this.checkBoxGallery.Name = "checkBoxGallery";
            this.checkBoxGallery.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGallery.TabIndex = 11;
            this.checkBoxGallery.Text = "Galerie";
            this.checkBoxGallery.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.checkBoxGallery);
            this.Controls.Add(this.checkBoxPrivate);
            this.Controls.Add(this.checkBoxPublic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWindow";
            this.Text = "Puush Backup";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLaClefToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxPublic;
        private System.Windows.Forms.CheckBox checkBoxPrivate;
        private System.Windows.Forms.CheckBox checkBoxGallery;
    }
}

