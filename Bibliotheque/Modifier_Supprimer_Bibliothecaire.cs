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
    public partial class Modifier_Supprimer_Bibliothecaire : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Modifier_Supprimer_Bibliothecaire()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update Bibliothecaire set NomBibl ='" + textBox1.Text + "' , PrenomBibl='" + textBox2.Text + "' , AdresseBibl='" + textBox3.Text + "' , TelephoneBibl=" + textBox4.Text + " , Utilisateur='" + textBox5.Text + "' , MotDePass='" + textBox6.Text + "' , Permission='" + comboBox1.SelectedItem.ToString() + "' where CodeBibl='" + comboBox2.SelectedItem.ToString() + "'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Modifier Avec Succe", "Modifier Bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Bibliothecaire where CodeBibl = " + comboBox2.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Bibliothecaire where CodeBibl=" + comboBox2.Text.ToString() + "";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string nom = dr.GetValue(1).ToString();
                string prenom = dr.GetValue(2).ToString();
                string adresse = dr.GetValue(3).ToString();
                string telephone = dr.GetValue(4).ToString();
                string utilisateur = dr.GetValue(5).ToString();
                string motdepasse = dr.GetValue(6).ToString();
                string permission = dr.GetValue(7).ToString();
                textBox1.Text = nom;
                textBox2.Text = prenom;
                textBox3.Text = adresse;
                textBox4.Text = telephone;
                textBox5.Text = utilisateur;
                textBox6.Text = motdepasse;
                comboBox1.Text = permission;

            }
            dr.Close();
            cnx.Close();
        }

        private void Modifier_Supprimer_Bibliothecaire_Load(object sender, EventArgs e)
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
    }
}
