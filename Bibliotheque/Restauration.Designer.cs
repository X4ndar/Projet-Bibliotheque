namespace Bibliotheque
{
    partial class Restauration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restauration));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_restauration = new System.Windows.Forms.Button();
            this.buttonSelectBak = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(429, 25);
            this.textBox1.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_cancel.Image")));
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(486, 189);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 30);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_restauration
            // 
            this.button_restauration.Image = ((System.Drawing.Image)(resources.GetObject("button_restauration.Image")));
            this.button_restauration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_restauration.Location = new System.Drawing.Point(335, 189);
            this.button_restauration.Name = "button_restauration";
            this.button_restauration.Size = new System.Drawing.Size(89, 30);
            this.button_restauration.TabIndex = 5;
            this.button_restauration.Text = "Restaurer";
            this.button_restauration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_restauration.UseVisualStyleBackColor = true;
            this.button_restauration.Click += new System.EventHandler(this.button_restauration_Click);
            // 
            // buttonSelectBak
            // 
            this.buttonSelectBak.Location = new System.Drawing.Point(31, 98);
            this.buttonSelectBak.Name = "buttonSelectBak";
            this.buttonSelectBak.Size = new System.Drawing.Size(75, 25);
            this.buttonSelectBak.TabIndex = 4;
            this.buttonSelectBak.Text = "...";
            this.buttonSelectBak.UseVisualStyleBackColor = true;
            this.buttonSelectBak.Click += new System.EventHandler(this.buttonSelectBak_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restauration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_restauration);
            this.Controls.Add(this.buttonSelectBak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Restauration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_restauration;
        private System.Windows.Forms.Button buttonSelectBak;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}