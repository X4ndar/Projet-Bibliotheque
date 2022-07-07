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
    public partial class Modifier_Supprimer_Adherent : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Modifier_Supprimer_Adherent()
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
            cmd = new SqlCommand("update Adherent set NumRecuAd =" + textBox2.Text + " , NomAd='" + textBox3.Text + "' , PrenomAd='" + textBox4.Text + "' , AdresseAd='" + textBox5.Text + "' , TelephoneAd=" + textBox6.Text + " where CodeAd='" + comboBox1.SelectedItem.ToString() + "'", cnx);
            cmd.ExecuteNonQuery();                                    
            cnx.Close();
            MessageBox.Show("Modifier Avec Succe","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Adherent where CodeAd = " + comboBox1.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Adherent where CodeAd=" + comboBox1.Text.ToString() + "";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string recu = dr.GetValue(1).ToString();
                string nom = dr.GetValue(2).ToString();
                string prenom = dr.GetValue(3).ToString();
                string adresse = dr.GetValue(4).ToString();
                string telephone = dr.GetValue(5).ToString();
                textBox2.Text = recu;
                textBox3.Text = nom;
                textBox4.Text = prenom;
                textBox5.Text = adresse;
                textBox6.Text = telephone;

            }
            dr.Close();
            cnx.Close();
        }

        private void Modifier_Supprimer_Adherent_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select CodeAd from Adherent ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CodeAd"].ToString());

            }
            dr.Close();
            cnx.Close();
        }
    }
}
