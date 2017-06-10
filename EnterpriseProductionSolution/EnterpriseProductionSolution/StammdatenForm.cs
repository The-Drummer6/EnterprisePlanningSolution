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

        public String cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";
        public StammdatenForm()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
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

            //Connection string.
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
             i = 0;
            rs.Close();
            rs.Open("Select * From PersMaschKosten", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            while (!rs.EOF)
            {
                metroGrid4.Rows.Add();
                metroGrid4.Rows[i].Cells["Arbeitsplatz"].Value = Convert.ToInt32(rs.Fields["Arbeitsplatz"].Value);
                metroGrid4.Rows[i].Cells["Lohn1"].Value = Convert.ToDouble(rs.Fields["1Lohn"].Value);
                metroGrid4.Rows[i].Cells["Lohn2"].Value = Convert.ToDouble(rs.Fields["2Lohn"].Value);
                metroGrid4.Rows[i].Cells["Lohn3"].Value = Convert.ToDouble(rs.Fields["3Lohn"].Value);
                metroGrid4.Rows[i].Cells["ÜLohn"].Value = Convert.ToDouble(rs.Fields["ÜLohn"].Value);
                metroGrid4.Rows[i].Cells["varKosten"].Value = Convert.ToDouble(rs.Fields["varKosten"].Value);
                metroGrid4.Rows[i].Cells["fixeKosten"].Value = Convert.ToDouble(rs.Fields["fixeKosten"].Value);
                rs.MoveNext();
                ++i;
            }
            rs.Close();
            cn.Close();


            refreshComboBox1();

        }




        //Struktur Stücklisten
        private void product1_Button_Click(object sender, EventArgs e)
        {
            metroGrid2.Rows.Clear();
            this.metroGrid2.Columns["Endprodukt"].Visible = true;
            this.metroGrid2.Columns["Ebene"].Visible = true;
            this.metroGrid2.Columns["Vorstufe"].Visible = true;
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {
                cn.Open(cnStr);

                rs.Open("Select * From Listen where Endprodukt = 1 ", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid2.Rows.Add();
                    metroGrid2.Rows[i].Cells["endprodukt"].Value = Convert.ToInt32(rs.Fields["Endprodukt"].Value);
                    metroGrid2.Rows[i].Cells["ebene"].Value = Convert.ToInt32(rs.Fields["Ebene"].Value);
                    metroGrid2.Rows[i].Cells["artikel"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid2.Rows[i].Cells["anzahl"].Value = Convert.ToInt32(rs.Fields["Anzahl"].Value);
                    metroGrid2.Rows[i].Cells["vorstufe"].Value = Convert.ToInt32(rs.Fields["Vorstufe"].Value);
                    rs.MoveNext();
                    i++;
                }
                rs.Close();
            }
            catch (Exception fehler)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten", fehler);
            }
            finally
            {
                cn.Close();
            }
        }

        private void product2_Button_Click(object sender, EventArgs e)
        {
            metroGrid2.Rows.Clear();
            this.metroGrid2.Columns["Endprodukt"].Visible = true;
            this.metroGrid2.Columns["Ebene"].Visible = true;
            this.metroGrid2.Columns["Vorstufe"].Visible = true;
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {
                cn.Open(cnStr);

                rs.Open("Select * From Listen where Endprodukt = 2 ", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid2.Rows.Add();
                    metroGrid2.Rows[i].Cells["endprodukt"].Value = Convert.ToInt32(rs.Fields["Endprodukt"].Value);
                    metroGrid2.Rows[i].Cells["ebene"].Value = Convert.ToInt32(rs.Fields["Ebene"].Value);
                    metroGrid2.Rows[i].Cells["artikel"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid2.Rows[i].Cells["anzahl"].Value = Convert.ToInt32(rs.Fields["Anzahl"].Value);
                    metroGrid2.Rows[i].Cells["vorstufe"].Value = Convert.ToInt32(rs.Fields["Vorstufe"].Value);
                    rs.MoveNext();
                    i++;
                }
                rs.Close();
            }
            catch (Exception fehler)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten", fehler);
            }
            finally
            {
                cn.Close();
            }
        }

        private void product3_Button_Click(object sender, EventArgs e)
        {
            metroGrid2.Rows.Clear();
            this.metroGrid2.Columns["Endprodukt"].Visible = true;
            this.metroGrid2.Columns["Ebene"].Visible = true;
            this.metroGrid2.Columns["Vorstufe"].Visible = true;
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {
                cn.Open(cnStr);

                rs.Open("Select * From Listen where Endprodukt = 3 ", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid2.Rows.Add();
                    metroGrid2.Rows[i].Cells["endprodukt"].Value = Convert.ToInt32(rs.Fields["Endprodukt"].Value);
                    metroGrid2.Rows[i].Cells["ebene"].Value = Convert.ToInt32(rs.Fields["Ebene"].Value);
                    metroGrid2.Rows[i].Cells["artikel"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid2.Rows[i].Cells["anzahl"].Value = Convert.ToInt32(rs.Fields["Anzahl"].Value);
                    metroGrid2.Rows[i].Cells["vorstufe"].Value = Convert.ToInt32(rs.Fields["Vorstufe"].Value);
                    rs.MoveNext();
                    i++;
                }
                rs.Close();
            }
            catch (Exception fehler)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten", fehler);
            }
            finally
            {
                cn.Close();
            }
        }

        private void productAll_Button_Click(object sender, EventArgs e)
        {
            metroGrid2.Rows.Clear();
            this.metroGrid2.Columns["Endprodukt"].Visible = true;
            this.metroGrid2.Columns["Ebene"].Visible = true;
            this.metroGrid2.Columns["Vorstufe"].Visible = true;
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {
                cn.Open(cnStr);

                rs.Open("Select * From Listen", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid2.Rows.Add();
                    metroGrid2.Rows[i].Cells["endprodukt"].Value = Convert.ToInt32(rs.Fields["Endprodukt"].Value);
                    metroGrid2.Rows[i].Cells["ebene"].Value = Convert.ToInt32(rs.Fields["Ebene"].Value);
                    metroGrid2.Rows[i].Cells["artikel"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid2.Rows[i].Cells["anzahl"].Value = Convert.ToInt32(rs.Fields["Anzahl"].Value);
                    metroGrid2.Rows[i].Cells["vorstufe"].Value = Convert.ToInt32(rs.Fields["Vorstufe"].Value);
                    rs.MoveNext();
                    i++;
                }
                rs.Close();
            }
            catch (Exception fehler)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten", fehler);
            }
            finally
            {
                cn.Close();
            }
        }

        //Mengen Stückliste
        private void menge_Produkt1_Button_Click(object sender, EventArgs e)
        {
            metroGrid3.Rows.Clear();
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                rs.Open("Select Artikel, Sum(Anzahl) as Anzahl_Menge From Listen where Endprodukt = 1 group by Artikel", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid3.Rows.Add();
                    metroGrid3.Rows[i].Cells["Artikel_Mengen"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid3.Rows[i].Cells["Anzahl_Menge"].Value = Convert.ToInt32(rs.Fields["Anzahl_Menge"].Value);
                    rs.MoveNext();
                    i++;
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

        private void menge_Produkt2_Button_Click(object sender, EventArgs e)
        {
            metroGrid3.Rows.Clear();
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                rs.Open("Select Artikel, Sum(Anzahl) as Anzahl_Menge From Listen where Endprodukt = 2 group by Artikel", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid3.Rows.Add();
                    metroGrid3.Rows[i].Cells["Artikel_Mengen"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid3.Rows[i].Cells["Anzahl_Menge"].Value = Convert.ToInt32(rs.Fields["Anzahl_Menge"].Value);
                    rs.MoveNext();
                    i++;
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

        private void menge_Produkt3_Button_Click(object sender, EventArgs e)
        {
            metroGrid3.Rows.Clear();
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                rs.Open("Select Artikel, Sum(Anzahl) as Anzahl_Menge From Listen where Endprodukt = 3 group by Artikel", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid3.Rows.Add();
                    metroGrid3.Rows[i].Cells["Artikel_Mengen"].Value = Convert.ToInt32(rs.Fields["Artikel"].Value);
                    metroGrid3.Rows[i].Cells["Anzahl_Menge"].Value = Convert.ToInt32(rs.Fields["Anzahl_Menge"].Value);
                    rs.MoveNext();
                    i++;
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
        //Lagerbestand
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try { 
            cn.Open(cnStr);
            string periode = metroComboBox1.Text;

                if (periode == "0")
                {
                    rs.Open("Select Startmenge, Artikelnummer, Startpreis From Artikelstammdaten", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    int i = 0;
                    metroGrid5.Rows.Clear();
                    while (!rs.EOF)
                    {
                        metroGrid5.Rows.Add();
                        metroGrid5.Rows[i].Cells["period"].Value = Convert.ToInt32(periode);
                        metroGrid5.Rows[i].Cells["id"].Value = Convert.ToInt32(rs.Fields["Artikelnummer"].Value);
                        metroGrid5.Rows[i].Cells["actualStock"].Value = Convert.ToInt32(rs.Fields["Startmenge"].Value);
                        metroGrid5.Rows[i].Cells["actualPrice"].Value = Convert.ToDouble(rs.Fields["Startpreis"].Value);
                        //metroGrid5.Rows[i].Cells["stockValue"].Value = ;
                        rs.MoveNext();
                        i++;
                    }
                }
                else
                {
                    rs.Open("Select * From warehousestock_article where period ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    int i = 0;
                    metroGrid5.Rows.Clear();
                    while (!rs.EOF)
                    {
                        metroGrid5.Rows.Add();
                        metroGrid5.Rows[i].Cells["period"].Value = Convert.ToInt32(rs.Fields["period"].Value);
                        metroGrid5.Rows[i].Cells["id"].Value = Convert.ToInt32(rs.Fields["id"].Value);
                        metroGrid5.Rows[i].Cells["actualStock"].Value = Convert.ToInt32(rs.Fields["amount"].Value);
                        metroGrid5.Rows[i].Cells["actualPrice"].Value = Convert.ToDouble(rs.Fields["price"].Value);
                        metroGrid5.Rows[i].Cells["stockValue"].Value = Convert.ToDouble(rs.Fields["stockValue"].Value);
                        rs.MoveNext();
                        i++;
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
    }
}

