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
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        private StammdatenForm stammdatenForm;
        private Periodenplanung planungsForm;

        public DashboardForm()
        {
            InitializeComponent();
        }
        //Import XML-File
        private void metroTile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string file;
                file = dlg.FileName;
                DBHandler.WriteData(file);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            stammdatenForm = new StammdatenForm();
            stammdatenForm.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            planungsForm = new Periodenplanung();
            planungsForm.Show();
            this.Hide();
        }
    }
}