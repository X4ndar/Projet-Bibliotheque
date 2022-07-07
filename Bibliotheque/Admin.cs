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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restauration restauration = new Restauration();
            restauration.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gererEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Emprunt gerer_emprunt = new Gerer_Emprunt();
            gerer_emprunt.Show();
        }

        private void gererBibliothécairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Bibliothecaire gerer_bibliothecaire = new Gerer_Bibliothecaire();
            gerer_bibliothecaire.Show();
        }

        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Bibliothecaire ajouter_bibliothecaire = new Ajouter_Bibliothecaire();
            ajouter_bibliothecaire.Show();
        }

        private void nouveauEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunt ajouter_emprunt = new Ajouter_Emprunt();
            ajouter_emprunt.Show();
        }
    }
}
