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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AfficherCaracters.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
                textBox_Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_connecter_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
            SqlDataAdapter Da = new SqlDataAdapter("select * from Bibliothecaire where Utilisateur like '" + textBox_Login.Text + "' and MotDePass like '" + textBox_Password.Text + "'", cnx);          
            DataTable Dt = new DataTable();
            Dt.Clear();
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                
                if (Dt.Rows[0][7].ToString() == "admin")
                {
                    
                    Admin admin = new Admin();
                    admin.Show();
                       
                }
                  
                else if (Dt.Rows[0][7].ToString() == "user")
                {
                    
                    User user = new User();
                    user.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Nom d'utilisateur ou le mot de passe est incorrect !!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
