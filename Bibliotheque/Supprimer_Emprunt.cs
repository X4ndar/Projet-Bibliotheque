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
    public partial class Supprimer_Emprunt : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Supprimer_Emprunt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Emprunt where CodeEmpr=" + comboBox4.Text.ToString() + "";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string livre = dr.GetValue(1).ToString();
                string bibliothecaire = dr.GetValue(2).ToString();
                string adherent = dr.GetValue(3).ToString();
                string date_emprunt = dr.GetValue(4).ToString();
                string date_return = dr.GetValue(5).ToString();
                comboBox1.Text = livre;
                comboBox2.Text = bibliothecaire;
                comboBox3.Text = adherent;
                dateTimePicker1.Text = date_emprunt;
                dateTimePicker2.Text = date_return;
                
            }
            dr.Close();
            cnx.Close();
        }

        private void Modifier_Supprimer_Emprunt_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select CodeEmpr from Emprunt ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["CodeEmpr"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Emprunt where CodeEmpr = " + comboBox4.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }


    }
}
