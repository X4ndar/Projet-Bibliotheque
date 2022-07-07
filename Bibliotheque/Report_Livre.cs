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
    public partial class Report_Livre : Form
    {
        public Report_Livre()
        {
            InitializeComponent();
        }

        private void Raport_Livre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bibliotheque_DBDataSet.Livre' table. You can move, or remove it, as needed.
            //this.LivreTableAdapter.Fill(this.Bibliotheque_DBDataSet.Livre);

            //this.reportViewer1.RefreshReport();
        }
    }
}
