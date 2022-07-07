namespace Bibliotheque
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adheronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauAdhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.adheronsToolStripMenuItem,
            this.empruntToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectionToolStripMenuItem.Image")));
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauLivreToolStripMenuItem,
            this.gererLivresToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editToolStripMenuItem.Text = "Livres";
            // 
            // nouveauLivreToolStripMenuItem
            // 
            this.nouveauLivreToolStripMenuItem.Name = "nouveauLivreToolStripMenuItem";
            this.nouveauLivreToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nouveauLivreToolStripMenuItem.Text = "Nouveau Livre";
            this.nouveauLivreToolStripMenuItem.Click += new System.EventHandler(this.nouveauLivreToolStripMenuItem_Click);
            // 
            // gererLivresToolStripMenuItem
            // 
            this.gererLivresToolStripMenuItem.Name = "gererLivresToolStripMenuItem";
            this.gererLivresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gererLivresToolStripMenuItem.Text = "Gerer Livres";
            this.gererLivresToolStripMenuItem.Click += new System.EventHandler(this.gererLivresToolStripMenuItem_Click);
            // 
            // adheronsToolStripMenuItem
            // 
            this.adheronsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauAdhérentToolStripMenuItem,
            this.gererAdhérentsToolStripMenuItem});
            this.adheronsToolStripMenuItem.Name = "adheronsToolStripMenuItem";
            this.adheronsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adheronsToolStripMenuItem.Text = "Adhérents";
            // 
            // nouveauAdhérentToolStripMenuItem
            // 
            this.nouveauAdhérentToolStripMenuItem.Name = "nouveauAdhérentToolStripMenuItem";
            this.nouveauAdhérentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nouveauAdhérentToolStripMenuItem.Text = "Nouveau Adhérent";
            this.nouveauAdhérentToolStripMenuItem.Click += new System.EventHandler(this.nouveauAdhérentToolStripMenuItem_Click);
            // 
            // gererAdhérentsToolStripMenuItem
            // 
            this.gererAdhérentsToolStripMenuItem.Name = "gererAdhérentsToolStripMenuItem";
            this.gererAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gererAdhérentsToolStripMenuItem.Text = "Gerer Adhérents";
            this.gererAdhérentsToolStripMenuItem.Click += new System.EventHandler(this.gererAdhérentsToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauEmpruntToolStripMenuItem,
            this.gererEmpruntToolStripMenuItem});
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            // 
            // nouveauEmpruntToolStripMenuItem
            // 
            this.nouveauEmpruntToolStripMenuItem.Name = "nouveauEmpruntToolStripMenuItem";
            this.nouveauEmpruntToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nouveauEmpruntToolStripMenuItem.Text = "Nouveau Emprunt";
            // 
            // gererEmpruntToolStripMenuItem
            // 
            this.gererEmpruntToolStripMenuItem.Name = "gererEmpruntToolStripMenuItem";
            this.gererEmpruntToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gererEmpruntToolStripMenuItem.Text = "Gerer Emprunt";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Biobiothéque";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adheronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauAdhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererEmpruntToolStripMenuItem;

    }
}