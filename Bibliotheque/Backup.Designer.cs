namespace Bibliotheque
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.button_backup = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(29, 100);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(75, 25);
            this.buttonSelectPath.TabIndex = 0;
            this.buttonSelectPath.Text = "...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // button_backup
            // 
            this.button_backup.Image = ((System.Drawing.Image)(resources.GetObject("button_backup.Image")));
            this.button_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_backup.Location = new System.Drawing.Point(331, 191);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(101, 30);
            this.button_backup.TabIndex = 1;
            this.button_backup.Text = "Sauvegarder";
            this.button_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_backup.UseVisualStyleBackColor = true;
            this.button_backup.Click += new System.EventHandler(this.button_backup_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_cancel.Image")));
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(484, 191);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 30);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(429, 25);
            this.textBox1.TabIndex = 3;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_backup);
            this.Controls.Add(this.buttonSelectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarder";
           // this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}