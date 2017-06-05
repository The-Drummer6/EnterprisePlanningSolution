using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterprisePlanningSolution
{
    public partial class StammdatenForm : MetroFramework.Forms.MetroForm
    {
        public StammdatenForm()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
           DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void StammdatenForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PPS_DatenbankDataSet.Artikelstammdaten' table. You can move, or remove it, as needed.
            this.artikelstammdatenTableAdapter.Fill(this._PPS_DatenbankDataSet.Artikelstammdaten);

        }
    }
}
