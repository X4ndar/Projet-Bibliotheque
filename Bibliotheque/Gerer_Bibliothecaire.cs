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
    public partial class Gerer_Bibliothecaire : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public Gerer_Bibliothecaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Bibliothecaire ajouter_bibliothecaire = new Ajouter_Bibliothecaire();
            ajouter_bibliothecaire.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Bibliothecaire", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Bibliothecaire.DataSource = dt;
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Bibliothecaire modifier_supprimer_bibliothecaire = new Modifier_Supprimer_Bibliothecaire();
            modifier_supprimer_bibliothecaire.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Bibliothecaire modifier_supprimer_bibliothecaire = new Modifier_Supprimer_Bibliothecaire();
            modifier_supprimer_bibliothecaire.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report_Bibliothecaire2 rb = new Report_Bibliothecaire2();
            rb.SetParameterValue("CodeBibl", dataGridView_Bibliothecaire.CurrentRow.Cells[0].Value.ToString());
            Report_Bibliothecaire rbibl = new Report_Bibliothecaire();
            rbibl.crystalReportViewer1.ReportSource = rb;
            rbibl.crystalReportViewer1.Refresh();
            rbibl.Show();
        }

        private void Gerer_Bibliothecaire_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Bibliothecaire", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Bibliothecaire.DataSource = dt;
            cnx.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Bibliothecaire where convert(varchar(10),CodeBibl)+NomBibl+PrenomBibl like '%" + textBox1.Text + "%' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Bibliothecaire.DataSource = dt;
            dr.Close();
        }
    }
}
