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
    public partial class Report_Bibliothecaire : Form
    {
        public Report_Bibliothecaire()
        {
            InitializeComponent();
        }

        private void Raport_Bibliothecaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bibliotheque_DBDataSet.Bibliothecaire' table. You can move, or remove it, as needed.
            //this.BibliothecaireTableAdapter.Fill(this.Bibliotheque_DBDataSet.Bibliothecaire);

            //this.reportViewer1.RefreshReport();
        }
    }
}
