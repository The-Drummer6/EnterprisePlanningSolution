using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnterprisePlanningSolution
{
    public partial class ErgebnisseForm : MetroFramework.Forms.MetroForm
    {
        public int maxLagerwert = 250000;
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

            // Lade die Jeweiligen Tabs
            ErgebnisseForm_LoadBestand(cn, rs);
            ErgebnisseForm_LoadBestellungen(cn, rs);
            ErgebnisseForm_LoadZugang(cn, rs);
            ErgebnisseForm_LoadKennzahl(cn, rs);

            /*
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
            rs.Close(); */
            cn.Close();


            refreshComboBox1();
            refreshComboBox2();
            refreshComboBox3();
            refreshComboBox4();

        }
        private void ErgebnisseForm_LoadBestand(ADODB.Connection cn, ADODB.Recordset rs)
        {


        }

        private void ErgebnisseForm_LoadBestellungen(ADODB.Connection cn, ADODB.Recordset rs)
        {
            rs.Open("Select * From myOrderlist", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int i = 0;

            while (!rs.EOF)
            {
                metroGrid2.Rows.Add();
                metroGrid2.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                metroGrid2.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["quantity"].Value;
                // Überprüfung auf Eil oder Normalbestellung
                if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                {
                    metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                }
                else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                {
                    metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
                }
                rs.MoveNext();
                ++i;
            }
            i = 0;
            rs.Close();
        }

        private void ErgebnisseForm_LoadZugang(ADODB.Connection cn, ADODB.Recordset rs)
        {
            rs.Open("Select * From Lagerzugang", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int i = 0;

            while (!rs.EOF)
            {
                metroGrid3.Rows.Add();
                metroGrid3.Rows[i].Cells["Artikelnummer_Zugang"].Value = rs.Fields["article"].Value;
                metroGrid3.Rows[i].Cells["Bestellperiode_Zugang"].Value = rs.Fields["orderperiod"].Value;
                // Überprüfung auf Eil oder Normalbestellung
                if (Convert.ToString(rs.Fields["mode"].Value) == "4")
                {
                    metroGrid3.Rows[i].Cells["Modus_Zugang"].Value = "Eil";
                }
                else if (Convert.ToString(rs.Fields["mode"].Value) == "5")
                {
                    metroGrid3.Rows[i].Cells["Modus_Zugang"].Value = "Normal";
                }
                metroGrid3.Rows[i].Cells["Lieferzeit_Zugang"].Value = rs.Fields["Lieferzeit"].Value;
                metroGrid3.Rows[i].Cells["Menge_Zugang"].Value = rs.Fields["amount"].Value;
                metroGrid3.Rows[i].Cells["Preis_Zugang"].Value = rs.Fields["price"].Value;
                rs.MoveNext();
                ++i;
            }
            i = 0;
            rs.Close();
        }

        private void ErgebnisseForm_LoadKennzahl(ADODB.Connection cn, ADODB.Recordset rs)
        {
            ADODB.Connection cnn = new ADODB.Connection();
            ADODB.Recordset rss = new ADODB.Recordset();
            try
            {
                cnn.Open(cnStr);
                rss.Open("Select * From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                int i = 0;
                double gewinn = 0;
                gewinnDiagramm.Series.Clear();
                Series S1 = new Series();
                gewinnDiagramm.Series.Add(S1);
                gewinnDiagramm.Series[0].Name = "Gewinn";
                while (!rss.EOF)
                {
                    gewinn = Convert.ToDouble(rss.Fields["profit_current"].Value);
                    S1.Points.AddXY("Periode " + (i+1), gewinn);
                    gewinnDiagramm.Series[0].Points[i].AxisLabel = "Periode " + (i+1) ;
                    rss.MoveNext();
                    i++;
                }
                
                rss.Close();
                cnn.Close();
            }
            catch (Exception fehler) { Console.WriteLine("Ein Fehler ist aufgetreten", fehler); }
        }

        // Box 1 of 4
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            double warehouseValue = 0;
            double freeSpace = 250000;
            double anzahl = 1;
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox1.Text;


                rs.Open("Select stockvalue From warehousestock_totalvalue where period='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                warehouseValue = Convert.ToDouble(rs.Fields["stockvalue"].Value);
                freeSpace = maxLagerwert - warehouseValue;
                if (warehouseValue > 250000)
                {
                    anzahl = Math.Floor(250000 / warehouseValue);
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
            lagerwertLabel.Text = Convert.ToString(warehouseValue);
            anzahlLagerLabel.Text = Convert.ToString(anzahl);
            lagerTortendiagramm.Titles["Title1"].Text = Convert.ToString(anzahl) + ". Lager";
            lagerTortendiagramm.Series["Series1"].Points.Clear();
            lagerTortendiagramm.Series["Series1"].Points.Add(warehouseValue);
            lagerTortendiagramm.Series["Series1"].Points[0].LegendText = "Lagerwert";
            lagerTortendiagramm.Series["Series1"].Points[0].Color = Color.Red;
            lagerTortendiagramm.Series["Series1"].Points.Add(freeSpace);
            lagerTortendiagramm.Series["Series1"].Points[1].LegendText = "freier Lagerplatz";
            lagerTortendiagramm.Series["Series1"].Points[1].Color = Color.Green;
        }



        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox2.Text;
                if (periode == "Alle Perioden")
                {
                    rs.Open("Select * From abf_Lieferzeitpunkt_bestellte_ware", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid2.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid2.Rows.Add();
                        metroGrid2.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                        metroGrid2.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["Menge"].Value;
                        metroGrid2.Rows[i].Cells["geplanter_Lieferzeitpunkt"].Value = rs.Fields["Lieferperiode"].Value;
                        metroGrid2.Rows[i].Cells["orderPeriod"].Value = rs.Fields["orderperiod"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToString(rs.Fields["mode"].Value) == "4")
                        {
                            metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                        }
                        else if (Convert.ToString(rs.Fields["mode"].Value) == "5")
                        {
                            metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
                        }
                        rs.MoveNext();
                        ++i;
                    }
                }
                else
                {
                    rs.Open("Select * From abf_Lieferzeitpunkt_bestellte_ware where orderperiod ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid2.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid2.Rows.Add();
                        metroGrid2.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                        metroGrid2.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["Menge"].Value;
                        metroGrid2.Rows[i].Cells["geplanter_Lieferzeitpunkt"].Value = rs.Fields["Lieferperiode"].Value;
                        metroGrid2.Rows[i].Cells["orderPeriod"].Value = rs.Fields["orderperiod"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToString(rs.Fields["mode"].Value) == "4")
                        {
                            metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                        }
                        else if (Convert.ToString(rs.Fields["mode"].Value) == "5")
                        {
                            metroGrid2.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
                        }
                        rs.MoveNext();
                        ++i;
                    }
                    //i = 0;
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

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox3.Text;

                rs.Open("Select * From Lagerzugang where period ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                metroGrid3.Rows.Clear();
                int i = 0;

                while (!rs.EOF)
                {
                    metroGrid3.Rows.Add();
                    metroGrid3.Rows[i].Cells["Artikelnummer_Zugang"].Value = rs.Fields["article"].Value;
                    metroGrid3.Rows[i].Cells["Bestellperiode_Zugang"].Value = rs.Fields["orderperiod"].Value;
                    // Überprüfung auf Eil oder Normalbestellung
                    if (Convert.ToString(rs.Fields["mode"].Value) == "4")
                    {
                        metroGrid3.Rows[i].Cells["Modus_Zugang"].Value = "Eil";
                    }
                    else if (Convert.ToString(rs.Fields["mode"].Value) == "5")
                    {
                        metroGrid3.Rows[i].Cells["Modus_Zugang"].Value = "Normal";
                    }
                    metroGrid3.Rows[i].Cells["Lieferzeit_Zugang"].Value = rs.Fields["Lieferzeit"].Value;
                    metroGrid3.Rows[i].Cells["Menge_Zugang"].Value = rs.Fields["amount"].Value;
                    metroGrid3.Rows[i].Cells["Preis_Zugang"].Value = rs.Fields["price"].Value;
                    rs.MoveNext();
                    ++i;
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

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            double lagerwert;
            double lagerkosten;
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox4.Text;
                rs.Open("Select * From summary where period='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Select * From warehousestock_totalvalue where period='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                metroGrid4.Rows.Clear();



                metroGrid4.Rows.Add();
                lagerwert = Convert.ToDouble(rs2.Fields["stockvalue"].Value);
                metroGrid4.Rows[0].Cells["Gewinn"].Value = rs.Fields["profit_current"].Value;
                metroGrid4.Rows[0].Cells["GewinnDurchschnitt"].Value = rs.Fields["profit_average"].Value;
                metroGrid4.Rows[0].Cells["GewinnGesamt"].Value = rs.Fields["profit_all"].Value;
                metroGrid4.Rows[0].Cells["Lagerwert_Kenn"].Value = rs2.Fields["stockvalue"].Value;
                if (lagerwert <= 250000.00)
                {
                    lagerkosten = Math.Round(lagerwert * 0.006, 2); //TODO: Durchschnittliche Lagerkosten
                    metroGrid4.Rows[0].Cells["Lagerkosten_Kenn"].Value = lagerkosten;
                    metroGrid4.Rows[0].Cells["AnzahlLager_Kenn"].Value = "1";

                }
                else
                {
                    lagerkosten = Math.Round(250000 * 0.006, 2); //1.500 für das erste Lager
                    lagerkosten += 5300.00;
                    lagerkosten += Math.Round((lagerwert - 250000) * 0.016, 2);
                    metroGrid4.Rows[0].Cells["Lagerkosten_Kenn"].Value = lagerkosten;
                    metroGrid4.Rows[0].Cells["AnzahlLager_Kenn"].Value = "2"; //TODO: Alle Fälle abdecken bei multiplen von 250.000?
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

        private void refreshComboBox2()
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            cn.Open(cnStr);

            rs.Open("Select distinct period From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            List<string> Liste = new List<string>();
            Liste.Add("Alle Perioden");
            while (!rs.EOF)
            {
                string p = Convert.ToString(rs.Fields["period"].Value);
                Liste.Add(p);
                rs.MoveNext();
            }
            rs.Close();
            cn.Close();

            metroComboBox2.DataSource = Liste;
        }
        private void refreshComboBox3()
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            cn.Open(cnStr);

            rs.Open("Select distinct period From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            List<string> Liste = new List<string>();
            //Liste.Add("0");
            while (!rs.EOF)
            {
                string p = Convert.ToString(rs.Fields["period"].Value);
                Liste.Add(p);
                rs.MoveNext();
            }
            rs.Close();
            cn.Close();

            metroComboBox3.DataSource = Liste;
        }
        private void refreshComboBox4()
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            cn.Open(cnStr);

            rs.Open("Select distinct period From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

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

            metroComboBox4.DataSource = Liste;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void lagerTortendiagramm_Click(object sender, EventArgs e)
        {

        }
    }
}
