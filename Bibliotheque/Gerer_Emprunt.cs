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
    public partial class Gerer_Emprunt : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Gerer_Emprunt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt ajouter_emprunt = new Ajouter_Emprunt();
            ajouter_emprunt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Emprunt", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Emprunt.DataSource = dt;
            cnx.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Supprimer_Emprunt modifier_supprimer_emprunt = new Supprimer_Emprunt();
            modifier_supprimer_emprunt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report_Emprunt re = new Report_Emprunt();
            re.crystalReportViewer1.RefreshReport();
            re.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Emprunt where Titre like '" + textBox1.Text + "'";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Emprunt.DataSource = dt;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Emprunt where CodeLv like '%" + textBox1.Text + "%' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Emprunt.DataSource = dt;
            dr.Close();
        }

        private void Gerer_Emprunt_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Emprunt", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Emprunt.DataSource = dt;
            cnx.Close();
        }
    }
}
