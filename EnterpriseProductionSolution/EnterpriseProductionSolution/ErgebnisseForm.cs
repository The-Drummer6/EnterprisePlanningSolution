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
    public partial class ErgebnisseForm : MetroFramework.Forms.MetroForm
    {
        public String cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";

        public ErgebnisseForm()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
        }

        private void ErgebnisseForm_Load(object sender, EventArgs e)
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            //Connection string.
            cn.Open(cnStr);

            rs.Open("Select * From warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Artikelnummer_Bestand"].Value = Convert.ToInt32(rs.Fields["id"].Value);
                metroGrid1.Rows[i].Cells["Startmenge_Bestand"].Value = rs.Fields["startamount"].Value;
                metroGrid1.Rows[i].Cells["Menge_Bestand"].Value = rs.Fields["amount"].Value;
                metroGrid1.Rows[i].Cells["Prozentmenge_Bestand"].Value = rs.Fields["pct"].Value;
                metroGrid1.Rows[i].Cells["Preis_Bestand"].Value = rs.Fields["price"].Value;
                metroGrid1.Rows[i].Cells["Lagerwert_Bestand"].Value = rs.Fields["stockvalue"].Value;
                rs.MoveNext();
                ++i;
            }
            i = 0;
            rs.Close();
            cn.Close();


            refreshComboBox1();

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Box 1 of 4
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox1.Text;

                if (periode == "0")
                {
                    rs.Open("Select * From warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    int i = 0;
                    metroGrid1.Rows.Clear();
                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Bestand"].Value = Convert.ToInt32(rs.Fields["id"].Value);
                        metroGrid1.Rows[i].Cells["Startmenge_Bestand"].Value = rs.Fields["startamount"].Value;
                        metroGrid1.Rows[i].Cells["Menge_Bestand"].Value = rs.Fields["amount"].Value;
                        metroGrid1.Rows[i].Cells["Prozentmenge_Bestand"].Value = rs.Fields["pct"].Value;
                        metroGrid1.Rows[i].Cells["Preis_Bestand"].Value = rs.Fields["price"].Value;
                        metroGrid1.Rows[i].Cells["Lagerwert_Bestand"].Value = rs.Fields["stockvalue"].Value;
                        rs.MoveNext();
                        ++i;
                    }
                }
                else
                {
                    rs.Open("Select * From warehousestock_article where period ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    int i = 0;
                    metroGrid1.Rows.Clear();
                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Bestand"].Value = Convert.ToInt32(rs.Fields["id"].Value);
                        metroGrid1.Rows[i].Cells["Startmenge_Bestand"].Value = Convert.ToInt32(rs.Fields["startamount"].Value);
                        metroGrid1.Rows[i].Cells["Menge_Bestand"].Value = Convert.ToInt32(rs.Fields["amount"].Value);
                        metroGrid1.Rows[i].Cells["Prozentmenge_Bestand"].Value = rs.Fields["pct"].Value;
                        metroGrid1.Rows[i].Cells["Preis_Bestand"].Value = Convert.ToDouble(rs.Fields["price"].Value);
                        metroGrid1.Rows[i].Cells["Lagerwert_Bestand"].Value = Convert.ToDouble(rs.Fields["stockvalue"].Value);
                        rs.MoveNext();
                        ++i;
                        /*
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["period"].Value = Convert.ToInt32(rs.Fields["period"].Value);
                        metroGrid1.Rows[i].Cells["id"].Value = Convert.ToInt32(rs.Fields["id"].Value);
                        metroGrid1.Rows[i].Cells["actualStock"].Value = Convert.ToInt32(rs.Fields["amount"].Value);
                        metroGrid1.Rows[i].Cells["actualPrice"].Value = Convert.ToDouble(rs.Fields["price"].Value);
                        metroGrid1.Rows[i].Cells["stockValue"].Value = Convert.ToDouble(rs.Fields["stockValue"].Value);
                        rs.MoveNext();
                        i++;
                        */
                    }
                }
                rs.Close();
            }
            catch (Exception fehler)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten", fehler);              //Try catch überprüfen....
            }
            finally
            {
                cn.Close();
            }

        }

        private void refreshComboBox1()
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            cn.Open(cnStr);

            rs.Open("Select distinct period From warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            List<int> Liste = new List<int>();
            Liste.Add(0);
            while (!rs.EOF)
            {
                int p = Convert.ToInt32(rs.Fields["period"].Value);
                Liste.Add(p);
                rs.MoveNext();
            }
            rs.Close();
            cn.Close();

            metroComboBox1.DataSource = Liste;
        }
    }
}
