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
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;

            //Connection string.
            cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";
            cn.Open(cnStr);

            rs.Open("Select * From Artikelstammdaten", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Artikelnummer"].Value = Convert.ToInt32(rs.Fields["Artikelnummer"].Value);
                metroGrid1.Rows[i].Cells["Bezeichnung"].Value = rs.Fields["Bezeichnung"].Value;
                metroGrid1.Rows[i].Cells["Verwendung"].Value = rs.Fields["Verwendung"].Value;
                metroGrid1.Rows[i].Cells["Lieferkosten"].Value = rs.Fields["Lieferkosten"].Value;
                metroGrid1.Rows[i].Cells["Lieferzeit"].Value = rs.Fields["Lieferzeit"].Value;
                metroGrid1.Rows[i].Cells["Lieferzeitabweichung"].Value = rs.Fields["Lieferzeitabweichung"].Value;
                rs.MoveNext();
                ++i;
            }

            rs.Close();
            cn.Close();

        }
    }
}
