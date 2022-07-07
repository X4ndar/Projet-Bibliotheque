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
    
    public partial class Gerer_Adherent : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=MSAO-PC\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public Gerer_Adherent()
        {
            InitializeComponent();
        }

        private void Gerer_Adherent_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Adherent", cnx);
            dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            cnx.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent ajouter_adherent = new Ajouter_Adherent();
            ajouter_adherent.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Adherent modifier_supprimer_adherent = new Modifier_Supprimer_Adherent();
            modifier_supprimer_adherent.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier_Supprimer_Adherent modifier_supprimer_adherent = new Modifier_Supprimer_Adherent();
            modifier_supprimer_adherent.Show();
            
        }

        private void Actualiser()
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Adherent", cnx);
            dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            cnx.Close();

        }


        private void button4_Click(object sender, EventArgs e)
        {

            Report_Adherent2 ra = new Report_Adherent2();
            ra.SetParameterValue("CodeAd", dataGridView_Adherent.CurrentRow.Cells[0].Value.ToString());
            Report_Adherent rad = new Report_Adherent();
            rad.crystalReportViewer1.ReportSource = ra;
            rad.crystalReportViewer1.Refresh();
            rad.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Adherent where NomAd like '" + textBox1.Text + "' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Adherent.DataSource = dt;
            dr.Close();
        }
    }
}
