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
    public partial class Modifier_Supprimer_Livre : Form
    {

        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd ;
        SqlDataReader dr;

        public Modifier_Supprimer_Livre()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from Livre where CodeLv= '" + comboBox1.Text.ToString() + "'", cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string titre = dr.GetValue(1).ToString();
                string nom = dr.GetValue(2).ToString();
                string editeur = dr.GetValue(3).ToString();
                string pages = dr.GetValue(4).ToString();
                string quantite = dr.GetValue(5).ToString();
                string categorie = dr.GetValue(6).ToString();
                textBox2.Text = titre;
                textBox3.Text = nom;
                textBox4.Text = editeur;
                textBox5.Text = pages;
                textBox6.Text = quantite;
                textBox7.Text = categorie;
                

            }
            dr.Close();
            cnx.Close();


       }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update Livre set TitreLv ='" + textBox2.Text + "' , NomAuteurLv='" + textBox3.Text + "' , EditeurLv='" + textBox4.Text + "' , NbrPagesLv=" + textBox5.Text + " , QtteLv=" + textBox6.Text + ", Categorie='" + textBox7.Text + "' where CodeAd=" + comboBox1.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Modifier Avec Succe", "Modifier Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Livre where CodeLv=" + comboBox1.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Supprimer_Livre_Load(object sender, EventArgs e)
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
    }
}
