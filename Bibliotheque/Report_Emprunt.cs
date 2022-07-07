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
    public partial class Report_Emprunt : Form
    {
        public Report_Emprunt()
        {
            InitializeComponent();
        }

        private void Raport_Emprunt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bibliotheque_DBDataSet.Emprunt' table. You can move, or remove it, as needed.
            //this.EmpruntTableAdapter.Fill(this.Bibliotheque_DBDataSet.Emprunt);

            //this.reportViewer1.RefreshReport();
        }
    }
}
