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
    public partial class Restauration : Form
    {
        SqlConnection cnx = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Bibliotheque_DB; Integrated Security=True");
        SqlCommand cmd;

        public Restauration()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectBak_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button_restauration_Click(object sender, EventArgs e)
        {
            string restaurationQuery = "ALTER Database Bibliotheque_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Bibliotheque_DB From Disk='" + textBox1.Text + "'";
            cmd = new SqlCommand(restaurationQuery, cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Resauration Reaussi", "Resauration", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
