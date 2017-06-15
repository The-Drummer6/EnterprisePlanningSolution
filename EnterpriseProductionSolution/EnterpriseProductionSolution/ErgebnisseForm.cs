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


            //refreshComboBox1();

        }
        private void ErgebnisseForm_LoadBestand(ADODB.Connection cn, ADODB.Recordset rs)
        {
            rs.Open("Select * From warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Artikelnummer_Bestand"].Value = rs.Fields["id"].Value; // ist schon int auf DB
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
            //cn.Close();

        }

        private void ErgebnisseForm_LoadBestellungen(ADODB.Connection cn, ADODB.Recordset rs)
        {
            rs.Open("Select * From myOrderlist", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                metroGrid1.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["quantity"].Value;
                // Überprüfung auf Eil oder Normalbestellung
                if (Convert.ToInt32(rs.Fields["modus"].Value)== 4)
                {
                    metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                } else if(Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                {
                    metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
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
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Artikelnummer_Zugang"].Value = rs.Fields["article"].Value;
                metroGrid1.Rows[i].Cells["Bestellperiode_Zugang"].Value = rs.Fields["orderperiod"].Value;
                // Überprüfung auf Eil oder Normalbestellung
                if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                {
                    metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Eil";
                }
                else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                {
                    metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Normal";
                }
                metroGrid1.Rows[i].Cells["Lieferzeit_Zugang"].Value = rs.Fields["Lieferzeit"].Value;
                metroGrid1.Rows[i].Cells["Menge_Zugang"].Value = rs.Fields["amount"].Value;
                metroGrid1.Rows[i].Cells["Preis_Zugang"].Value = rs.Fields["price"].Value;
                rs.MoveNext();
                ++i;
            }
            i = 0;
            rs.Close();
        }

        private void ErgebnisseForm_LoadKennzahl(ADODB.Connection cn, ADODB.Recordset rs)
        {
            rs.Open("Select * From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["Gewinn"].Value = rs.Fields["profit_current"].Value;
                metroGrid1.Rows[i].Cells["GewinnDurchschnitt"].Value = rs.Fields["profit_average"].Value;
                metroGrid1.Rows[i].Cells["GewinnGesamt"].Value = rs.Fields["profit_all"].Value;
                rs.MoveNext();
                ++i;
            }
            i = 0;
            rs.Close();
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

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox2.Text;
                if(periode == "0")
                {
                    rs.Open("Select * From myOrderlist", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid2.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                        metroGrid1.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["quantity"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                        {
                            metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                        }
                        else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                        {
                            metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
                        }
                        rs.MoveNext();
                        ++i;
                    }
                    //i = 0;
                } else
                {
                    rs.Open("Select * From myOrderlist where period ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid2.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Bestellung"].Value = rs.Fields["article"].Value;
                        metroGrid1.Rows[i].Cells["Menge_Bestellung"].Value = rs.Fields["quantity"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                        {
                            metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Eil";
                        }
                        else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                        {
                            metroGrid1.Rows[i].Cells["Bestellart_Bestellung"].Value = "Normal";
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
                if (periode == "0")
                {
                    rs.Open("Select * From Lagerzugang", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid3.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Zugang"].Value = rs.Fields["article"].Value;
                        metroGrid1.Rows[i].Cells["Bestellperiode_Zugang"].Value = rs.Fields["orderperiod"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                        {
                            metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Eil";
                        }
                        else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                        {
                            metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Normal";
                        }
                        metroGrid1.Rows[i].Cells["Lieferzeit_Zugang"].Value = rs.Fields["Lieferzeit"].Value;
                        metroGrid1.Rows[i].Cells["Menge_Zugang"].Value = rs.Fields["amount"].Value;
                        metroGrid1.Rows[i].Cells["Preis_Zugang"].Value = rs.Fields["price"].Value;
                        rs.MoveNext();
                        ++i;
                    }
                    //i = 0;
                }
                else
                {
                    rs.Open("Select * From Lagerzugang where period ='" + periode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    metroGrid3.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Artikelnummer_Zugang"].Value = rs.Fields["article"].Value;
                        metroGrid1.Rows[i].Cells["Bestellperiode_Zugang"].Value = rs.Fields["orderperiod"].Value;
                        // Überprüfung auf Eil oder Normalbestellung
                        if (Convert.ToInt32(rs.Fields["modus"].Value) == 4)
                        {
                            metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Eil";
                        }
                        else if (Convert.ToInt32(rs.Fields["modus"].Value) == 5)
                        {
                            metroGrid1.Rows[i].Cells["Modus_Zugang"].Value = "Normal";
                        }
                        metroGrid1.Rows[i].Cells["Lieferzeit_Zugang"].Value = rs.Fields["Lieferzeit"].Value;
                        metroGrid1.Rows[i].Cells["Menge_Zugang"].Value = rs.Fields["amount"].Value;
                        metroGrid1.Rows[i].Cells["Preis_Zugang"].Value = rs.Fields["price"].Value;
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

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                cn.Open(cnStr);
                string periode = metroComboBox4.Text;
                if (periode == "0")
                {
                    rs.Open("Select * From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                    metroGrid4.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Gewinn"].Value = rs.Fields["profit_current"].Value;
                        metroGrid1.Rows[i].Cells["GewinnDurchschnitt"].Value = rs.Fields["profit_average"].Value;
                        metroGrid1.Rows[i].Cells["GewinnGesamt"].Value = rs.Fields["profit_all"].Value;
                        rs.MoveNext();
                        ++i;
                    }
                    //i = 0;
                }
                else
                {
                    rs.Open("Select * From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                    metroGrid4.Rows.Clear();
                    int i = 0;

                    while (!rs.EOF)
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells["Gewinn"].Value = rs.Fields["profit_current"].Value;
                        metroGrid1.Rows[i].Cells["GewinnDurchschnitt"].Value = rs.Fields["profit_average"].Value;
                        metroGrid1.Rows[i].Cells["GewinnGesamt"].Value = rs.Fields["profit_all"].Value;
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
