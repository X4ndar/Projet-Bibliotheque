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
    public partial class Gerer_Livre : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Gerer_Livre()
        {
            InitializeComponent();
        }

        private void Gerer_Livre_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Livre", cnx);
            dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            cnx.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Livre ajouter_livre = new Ajouter_Livre();
            ajouter_livre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Livre modifier_supprimer_livre = new Modifier_Supprimer_Livre();
            modifier_supprimer_livre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Livre modifier_supprimer_livre = new Modifier_Supprimer_Livre();
            modifier_supprimer_livre.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Livre", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            cnx.Close();

        }



        private void button4_Click(object sender, EventArgs e)
        {
            Report_Livre2 rl = new Report_Livre2();
            rl.SetParameterValue("Categorie", textBox2.Text);
            Report_Livre rlv = new Report_Livre();
            rlv.crystalReportViewer1.ReportSource = rl;
            rlv.crystalReportViewer1.Refresh();
            rlv.Show();
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Livre where TitreLv like '" + textBox1.Text + "' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            dr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Livre where Categorie like '" + textBox2.Text + "' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            dr.Close();
        }


    }
}
