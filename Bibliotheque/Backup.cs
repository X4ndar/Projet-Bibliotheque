using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bibliotheque
{
    public partial class Backup : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Backup()
        {
            InitializeComponent();
        }

        private void button_backup_Click(object sender, EventArgs e)
        {

            SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
            cnx.Open();
            string FichierNom = textBox1.Text + "\\Bibliotheque_DB" +DateTime.Now.ToShortDateString().Replace('/', '_') + "_" + DateTime.Now.ToLongTimeString().Replace(':', '_');
            SqlCommand cmd = new SqlCommand("backup database Bibliotheque_DB to disk ='" + FichierNom + ".bak'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("BackUp Reussi", "BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
