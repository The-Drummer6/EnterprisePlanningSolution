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
        private ErgebnisseForm ergebnissform;
        public string cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";

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

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ergebnissform = new ErgebnisseForm();
            ergebnissform.Show();
            this.Hide();
        }

        //Alle notwendigen Tabellen werden zurückgesetzt
        private void resetButton_Click(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            cn.Open(cnStr);

            try
            {
                rs.Open("DELETE FROM completedorders", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE FROM cycletimes", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM cycletimes_order", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM directsale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM futureinwardstockmovement", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM idletimecosts_sum", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM idletimecosts_workplace", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM inwardstockmovement", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM marketplacesale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM normalsale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM ordersinwork", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM tbl_general", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM waitingliststock", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM waitinglistworkstations", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM warehousestock_totalvalue", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM GeplanterBedarf", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM productionlist", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM myOrderlist WHERE period <> '0'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM Kapazitaetsplanung", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM Prognose", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM selldirect", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("DELETE * FROM sellwish", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                MessageBox.Show("Datenbanktabellen wurden erfolgreich gelöscht!");
            }
            catch (Exception test)
            {
                MessageBox.Show(test.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SpracheComboDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToString(SpracheComboDashboard.Text) == "English")
            {
                doLanguageEnglish();
            }
            else
            {
                doLanguageDeutsch();
            }
        }

        private void doLanguageDeutsch()
        {
            metroTile3.Text = "Stammdaten";
            metroTile2.Text = "Periodenplanung";
            metroTile1.Text = "XML-Import";
            metroTile4.Text = "Planungsergebnisse";
        }
        private void doLanguageEnglish()
        {
            metroTile3.Text = "Master data";
            metroTile2.Text = "Period planning";
            metroTile1.Text = "XML-Import";
            metroTile4.Text = "Planning results";

        }
    }
}