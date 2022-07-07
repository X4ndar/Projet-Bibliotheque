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
    public partial class Report_Adherent : Form
    {
        public Report_Adherent()
        {
            InitializeComponent();
        }

        private void Raport_Adherent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bibliotheque_DBDataSet.Adherent' table. You can move, or remove it, as needed.
            //this.AdherentTableAdapter.Fill(this.Bibliotheque_DBDataSet.Adherent);

            //this.reportViewer1.RefreshReport();
        }
    }
}
