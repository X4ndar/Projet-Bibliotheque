using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bibliotheque
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }


        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login cnx = new Login();
            cnx.Show();
            this.Hide();
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Livre ajouter_livre = new Ajouter_Livre();
            ajouter_livre.Show();
        }

        private void gererLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Livre gerer_livre = new Gerer_Livre();
            gerer_livre.Show();
        }

        private void nouveauAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Adherent ajouter_adherent = new Ajouter_Adherent();
            ajouter_adherent.Show();
        }

        private void gererAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Adherent gerer_livre = new Gerer_Adherent();
            gerer_livre.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        
      
    }
}
