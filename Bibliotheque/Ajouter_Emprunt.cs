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
    public partial class Ajouter_Emprunt : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;

        public Ajouter_Emprunt()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cnx.Open();
            cmd = new SqlCommand("select * from Livre where CodeLv='"+comboBox1.Text.ToString()+"'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CodeLv"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from Bibliothecaire where CodeBibl='" + comboBox2.Text.ToString() + "'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["CodeBibl"].ToString());

            }
            dr.Close();
            cnx.Close();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            cnx.Open();
            cmd = new SqlCommand("select * from Adherent where CodeAd='" + comboBox3.Text.ToString() + "'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["CodeAd"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void Ajouter_Emprunt_Load(object sender, EventArgs e)
        {

            get_adherent();
            get_bibliothecaire();
            get_livre();
      
        }


        public void get_livre()
        {

            cnx.Open();
            cmd = new SqlCommand("select CodeLv from Livre ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CodeLv"].ToString());

            }
            dr.Close();
            cnx.Close();

        }

        public void get_bibliothecaire()
        {

            cnx.Open();
            cmd = new SqlCommand("select CodeBibl from Bibliothecaire ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["CodeBibl"].ToString());

            }
            dr.Close();
            cnx.Close();

        }

        public void get_adherent()
        {

            cnx.Open();
            cmd = new SqlCommand("select CodeAd from Adherent ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["CodeAd"].ToString());

            }
            dr.Close();
            cnx.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cnx.Open();
            cmd = new SqlCommand("insert into Emprunt(CodeLv,CodeBibl,CodeAd,DateEmprunt,DateReturn) values('" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "'," + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "," + dateTimePicker2.Value.ToString("dd-MM-yyyy") + ")", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Ajoute Avec Succe", "Ajouter Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
