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
    public partial class Ajouter_Livre : Form
    {
        public Ajouter_Livre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into Livre values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + "," + textBox6.Text + ",'" + textBox7.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Ajoute Avec Succe","Ajouter Livre",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
