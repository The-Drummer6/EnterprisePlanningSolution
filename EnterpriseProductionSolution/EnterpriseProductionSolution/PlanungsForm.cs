using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterprisePlanningSolution
{
    public partial class Periodenplanung : MetroFramework.Forms.MetroForm
    {



        public string cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";
        int[,] sellwishList;
        int aktuellePeriode;
        int geladenePeriode;

        TextBox[,] P1TextBoxes;
        TextBox[,] P2TextBoxes;
        TextBox[,] P3TextBoxes;

        int[] P1Produkte = { 1, 26, 51, 16, 17, 50, 4, 10, 49, 7, 13, 18 };
        int[] P2Produkte = { 2, 26, 56, 16, 17, 55, 5, 11, 54, 8, 14, 19 };
        int[] P3Produkte = { 3, 26, 31, 16, 17, 30, 6, 12, 29, 9, 15, 20 };

        int[] rowsForWaitingList = { 0, 2, 5, 8 };

        int?[] P1LagerstandVP;
        int?[] P2LagerstandVP;
        int?[] P3LagerstandVP;

        int?[] P1LagerstandAP;
        int?[] P2LagerstandAP;
        int?[] P3LagerstandAP;

        int?[] P1GeplanterBedarfVP;
        int?[] P2GeplanterBedarfVP;
        int?[] P3GeplanterBedarfVP;

        int?[] P1Warteschlange;
        int?[] P2Warteschlange;
        int?[] P3Warteschlange;

        int?[] P1WarteschlangeArbeitsplatz;
        int?[] P2WarteschlangeArbeitsplatz;
        int?[] P3WarteschlangeArbeitsplatz;

        int?[] P1Bearbeitung;
        int?[] P2Bearbeitung;
        int?[] P3Bearbeitung;

        String[] deutsch = { "Werte in DB eingetragen", "Werte in DB überschrieben", "In die Felder dürfen nur ganzzahlige Werte eingetragen werden.", "Werte wurden nicht gespeichert, da die eingegebenen Werte keine genzzahligen Werte sind.", "Produktionsprogramm für kommende Periode wird mit diesen Werten negativ. Der geplante Lagerwert wurde auf den klainstmöglichen Wert gesetzt." };
        String[] englisch = { "Values succesfully imported into DB", "Values successfully updated in DB", "You can input only intregal values into the fields.", "Importing values into DB failed, because only integral values are allowed.", "Productionprogram got negative. The value \'planned \' is setted to the smallest possible value." };


        int WERTE_EINGETRAGEN = 0;
        int WERTE_UEBERSCHRIEBEN = 1;
        int FORMAT_EXCEPTION = 2;
        int SPEICHER_EXCEPTION = 3;
        int NEGATIVE_PLANUNG = 4;

        //Boolean Wert für die Sichtbarkeit des SaveButton
        bool readyPrognose = false;
        bool readyDirektbezug = false;
        bool readyBedarf = false;
        bool readyDispo = false;
        bool readyProduktion = true;
        bool readyKapa = true;

        bool prüfung = true;


        public Periodenplanung()
        {
            InitializeComponent();
            bearbeiten();
            weiterButtonDispo.SelectedIndex = 0;
            metroTabControl2.SelectedIndex = 0;

            /// <summary>
            /// Belegung der Perioden Labels
            /// </summary>
            periodenLabel1.Text = Convert.ToString(getNewPeriod());
            periodenLabel2.Text = periodenLabel1.Text;
            tBPeriode.Text = periodenLabel1.Text;
            periodenLabel3.Text = periodenLabel2.Text;
            periodenLabelDispo.Text = periodenLabel2.Text;
            periodenLabelProduktion.Text = periodenLabel2.Text;
            periodenLabelKapa.Text = periodenLabel2.Text;

            addNewPeriod();
            aktuellePeriode = Convert.ToInt32(periodenLabel1.Text);
            // übersetzeStrings = Thread.CurrentThread.CurrentUICulture.Name == "de" ? deutsch : englisch;
            initializeTextboxes();
            // initalizeNumbers(aktuellePeriode);

            //SaveButton unsichtbar stellen
            saveButton.Visible = false;
        }

        private void bearbeiten()
        {

            this.tBGP1N0.ReadOnly = false;
            this.tBGP1N1.ReadOnly = false;
            this.tBGP1N2.ReadOnly = false;
            this.tBGP1N3.ReadOnly = false;
            this.tBGP2N0.ReadOnly = false;
            this.tBGP2N1.ReadOnly = false;
            this.tBGP2N2.ReadOnly = false;
            this.tBGP2N3.ReadOnly = false;
            this.tBGP3N0.ReadOnly = false;
            this.tBGP3N1.ReadOnly = false;
            this.tBGP3N2.ReadOnly = false;
            this.tBGP3N3.ReadOnly = false;

            this.tBPP1N0.ReadOnly = false;
            this.tBPP1N1.ReadOnly = false;
            this.tBPP1N2.ReadOnly = false;
            this.tBPP1N3.ReadOnly = false;
            this.tBPP2N0.ReadOnly = false;
            this.tBPP2N1.ReadOnly = false;
            this.tBPP2N2.ReadOnly = false;
            this.tBPP2N3.ReadOnly = false;
            this.tBPP3N0.ReadOnly = false;
            this.tBPP3N1.ReadOnly = false;
            this.tBPP3N2.ReadOnly = false;
            this.tBPP3N3.ReadOnly = false;
        }
        /// <summary>
        /// aktuelle Planperiode erhalten
        /// </summary>
        private int getNewPeriod()
        {
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            cn.Open(cnStr);

            rs.Open("Select distinct planPeriod From Prognose ORDER BY planPeriod Desc", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            List<int> Liste = new List<int>();
            while (!rs.EOF)
            {
                Liste.Add(Convert.ToInt32(rs.Fields["planPeriod"].Value));
                rs.MoveNext();
            }
            rs.Close();
            cn.Close();
            return Liste.Count + 1;
        }
        /// <summary>
        /// Neue Planperiode in DB erstellen
        /// </summary>
        private void addNewPeriod()
        {


            int neuPeriode = getNewPeriod();

            int cB = neuPeriode;
            int cB1 = neuPeriode + 1;
            int cB2 = neuPeriode + 2;
            int cB3 = neuPeriode + 3;
            int periodePrognose;

            tBPP0N0.Text = Convert.ToString(cB);
            tBPP0N1.Text = Convert.ToString(cB1);
            tBPP0N2.Text = Convert.ToString(cB2);
            tBPP0N3.Text = Convert.ToString(cB3);
            tBGP0N0.Text = Convert.ToString(cB);
            tBGP0N1.Text = Convert.ToString(cB1);
            tBGP0N2.Text = Convert.ToString(cB2);
            tBGP0N3.Text = Convert.ToString(cB3);

            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs0 = new ADODB.Recordset();
            ADODB.Recordset rs1 = new ADODB.Recordset();
            cn.Open(cnStr);

            rs1.Open("Select distinct period from summary ORDER BY period Desc", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            periodePrognose = Convert.ToInt32(rs1.Fields["period"].Value);
            rs1.Close();
            if (!(neuPeriode == periodePrognose + 1) || neuPeriode == 1)
            {


                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into Prognose (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);


                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB1 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB2 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (1,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (2,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into sellwish (article, quantity, planPeriod, period) values (3,0," + neuPeriode + "," + cB3 + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into selldirect (article, quantity, price, penalty, period) values (1,0,0,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into selldirect (article, quantity, price, penalty, period) values (2,0,0,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into selldirect (article, quantity, price, penalty, period) values (3,0,0,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into productionlist (article, quantity, period) values (1,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (2,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (3,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (18,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (13,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (7,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (49,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (10,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (4,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (50,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (17,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (16,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into productionlist (article, quantity, period) values (51,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (26,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (19,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (14,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (8,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (54,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (11,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (5,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (55,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (17,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (16,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (56,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rs0.Open("Insert into productionlist (article, quantity, period) values (26,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (20,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (15,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (9,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (29,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (12,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (6,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (30,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (17,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (16,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (31,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs0.Open("Insert into productionlist (article, quantity, period) values (26,0," + neuPeriode + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            }
            cn.Close();

        }
        /// <summary>
        /// Eingaben aus Prognose in DB schreiben
        /// </summary>
        private void weiterButton1_Click(object sender, EventArgs e)
        {
            readyPrognose = true;
            saveButtonVisible();

            if (tBPP1N0.Text == "" || tBPP1N1.Text == "" || tBPP1N2.Text == "" || tBPP1N3.Text == "" || tBPP2N0.Text == "" || tBPP2N1.Text == "" || tBPP2N2.Text == "" || tBPP2N3.Text == "" || tBPP3N0.Text == "" || tBPP3N1.Text == "" || tBPP3N2.Text == "" || tBPP3N3.Text == "" || tBGP1N0.Text == "" || tBGP1N1.Text == "" || tBGP1N2.Text == "" || tBGP1N3.Text == "" || tBGP2N0.Text == "" || tBGP2N1.Text == "" || tBGP2N2.Text == "" || tBGP2N3.Text == "" || tBGP3N0.Text == "" || tBGP3N1.Text == "" || tBGP3N2.Text == "" || tBGP3N3.Text == ""
                || (Convert.ToInt16(tBPP1N0.Text) < 0 || Convert.ToInt16(tBPP1N1.Text) < 0 || Convert.ToInt16(tBPP1N2.Text) < 0 || Convert.ToInt16(tBPP1N3.Text) < 0 || Convert.ToInt16(tBPP2N0.Text) < 0 || Convert.ToInt16(tBPP2N1.Text) < 0 || Convert.ToInt16(tBPP2N2.Text) < 0 || Convert.ToInt16(tBPP2N3.Text) < 0 || Convert.ToInt16(tBPP3N0.Text) < 0 || Convert.ToInt16(tBPP3N1.Text) < 0 || Convert.ToInt16(tBPP3N2.Text) < 0 || Convert.ToInt16(tBPP3N3.Text) < 0 || Convert.ToInt16(tBGP1N0.Text) < 0 || Convert.ToInt16(tBGP1N1.Text) < 0 || Convert.ToInt16(tBGP1N2.Text) < 0 || Convert.ToInt16(tBGP1N3.Text) < 0 || Convert.ToInt16(tBGP2N0.Text) < 0 || Convert.ToInt16(tBGP2N1.Text) < 0 || Convert.ToInt16(tBGP2N2.Text) < 0 || Convert.ToInt16(tBGP2N3.Text) < 0 || Convert.ToInt16(tBGP3N0.Text) < 0 || Convert.ToInt16(tBGP3N1.Text) < 0 || Convert.ToInt16(tBGP3N2.Text) < 0 || Convert.ToInt16(tBGP3N3.Text) < 0))
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Falsche Eingabe!" : "False input!";
                MessageBox.Show(LadeError);
                return;
            }

            int cB = Convert.ToInt32(periodenLabel1.Text);
            int cB1 = cB + 1;
            int cB2 = cB + 2;
            int cB3 = cB + 3;

            tBPP0N0.Text = Convert.ToString(cB);
            tBPP0N1.Text = Convert.ToString(cB1);
            tBPP0N2.Text = Convert.ToString(cB2);
            tBPP0N3.Text = Convert.ToString(cB3);
            tBGP0N0.Text = Convert.ToString(cB);
            tBGP0N1.Text = Convert.ToString(cB1);
            tBGP0N2.Text = Convert.ToString(cB2);
            tBGP0N3.Text = Convert.ToString(cB3);

            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rsD1 = new ADODB.Recordset();
            ADODB.Recordset rsD2 = new ADODB.Recordset();
            ADODB.Recordset rs0 = new ADODB.Recordset();
            ADODB.Recordset rs1 = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            ADODB.Recordset rs3 = new ADODB.Recordset();
            ADODB.Recordset rsSW0 = new ADODB.Recordset();
            ADODB.Recordset rsSW1 = new ADODB.Recordset();
            ADODB.Recordset rsSW2 = new ADODB.Recordset();
            ADODB.Recordset rsSW3 = new ADODB.Recordset();

            try
            {
                //Recordset

                cn.Open(cnStr);

                rs0.Open("Select * From Prognose where period =" + cB + " and  planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs1.Open("Select * From Prognose where period =" + cB1 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Select * From Prognose where period =" + cB2 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs3.Open("Select * From Prognose where period =" + cB3 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                rsSW0.Open("Select * From sellwish where period =" + cB + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rsSW1.Open("Select * From sellwish where period =" + cB1 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rsSW2.Open("Select * From sellwish where period =" + cB2 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rsSW3.Open("Select * From sellwish where period =" + cB3 + "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                while (!rs0.EOF)
                {

                    rs0.Fields["quantity"].Value = tBPP1N0.Text;
                    rs0.MoveNext();
                    rs0.Fields["quantity"].Value = tBPP2N0.Text;
                    rs0.MoveNext();
                    rs0.Fields["quantity"].Value = tBPP3N0.Text;
                    rs0.MoveNext();
                }
                while (!rs1.EOF)
                {
                    rs1.Fields["quantity"].Value = tBPP1N1.Text;
                    rs1.MoveNext();
                    rs1.Fields["quantity"].Value = tBPP2N1.Text;
                    rs1.MoveNext();
                    rs1.Fields["quantity"].Value = tBPP3N1.Text;
                    rs1.MoveNext();

                }
                while (!rs2.EOF)
                {
                    rs2.Fields["quantity"].Value = tBPP1N2.Text;
                    rs2.MoveNext();
                    rs2.Fields["quantity"].Value = tBPP2N2.Text;
                    rs2.MoveNext();
                    rs2.Fields["quantity"].Value = tBPP3N2.Text;
                    rs2.MoveNext();

                }
                while (!rs3.EOF)
                {
                    rs3.Fields["quantity"].Value = tBPP1N3.Text;
                    rs3.MoveNext();
                    rs3.Fields["quantity"].Value = tBPP2N3.Text;
                    rs3.MoveNext();
                    rs3.Fields["quantity"].Value = tBPP3N3.Text;
                    rs3.MoveNext();
                }
                while (!rsSW0.EOF)
                {
                    rsSW0.Fields["quantity"].Value = tBGP1N0.Text;
                    rsSW0.MoveNext();
                    rsSW0.Fields["quantity"].Value = tBGP2N0.Text;
                    rsSW0.MoveNext();
                    rsSW0.Fields["quantity"].Value = tBGP3N0.Text;
                    rsSW0.MoveNext();
                }
                while (!rsSW1.EOF)
                {
                    rsSW1.Fields["quantity"].Value = tBGP1N1.Text;
                    rsSW1.MoveNext();
                    rsSW1.Fields["quantity"].Value = tBGP2N1.Text;
                    rsSW1.MoveNext();
                    rsSW1.Fields["quantity"].Value = tBGP3N1.Text;
                    rsSW1.MoveNext();
                }
                while (!rsSW2.EOF)
                {
                    rsSW2.Fields["quantity"].Value = tBGP1N2.Text;
                    rsSW2.MoveNext();
                    rsSW2.Fields["quantity"].Value = tBGP2N2.Text;
                    rsSW2.MoveNext();
                    rsSW2.Fields["quantity"].Value = tBGP3N2.Text;
                    rsSW2.MoveNext();

                }
                while (!rsSW3.EOF)
                {
                    rsSW3.Fields["quantity"].Value = tBGP1N3.Text;
                    rsSW3.MoveNext();
                    rsSW3.Fields["quantity"].Value = tBGP2N3.Text;
                    rsSW3.MoveNext();
                    rsSW3.Fields["quantity"].Value = tBGP3N3.Text;
                    rsSW3.MoveNext();
                }
            }
            catch (Exception test)
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Fehler bei der Eingabe: " + test.Message : "Error in the input";
                MessageBox.Show(LadeError);

            }
            finally
            {
                rs0.Close();
                rs1.Close();
                rs2.Close();
                rs3.Close();
                rsSW0.Close();
                rsSW1.Close();
                rsSW2.Close();
                rsSW3.Close();
                cn.Close();
            }

            weiterButtonDispo.SelectedIndex = 1;

        }
        /// <summary>
        /// Eingaben aus Direktbezug Tab in DB schreiben
        /// </summary>
        private void mweiterButton2_Click(object sender, EventArgs e)
        {
            readyDirektbezug = true;
            saveButtonVisible();

            if (tBP1.Text == "" || tBP1P.Text == "" || tBP1S.Text == "" || tBP2.Text == "" || tBP2P.Text == "" || tBP2S.Text == "" || tBP3.Text == "" || tBP3P.Text == "" || tBP3S.Text == ""
                || (Convert.ToInt32(tBP1.Text) < 0 || Convert.ToInt32(tBP1P.Text) < 0 || Convert.ToInt32(tBP1S.Text) < 0 || Convert.ToInt32(tBP2.Text) < 0 || Convert.ToInt32(tBP2P.Text) < 0 || Convert.ToInt32(tBP2S.Text) < 0 || Convert.ToInt32(tBP3.Text) < 0 || Convert.ToInt32(tBP3P.Text) < 0 || Convert.ToInt32(tBP3S.Text) < 0))
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Falsche Eingabe!" : "False input!";
                MessageBox.Show(LadeError);
                return;

            }

            int cB = Convert.ToInt32(periodenLabel1.Text);


            tBPeriode.Text = Convert.ToString(cB);


            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs1 = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            ADODB.Recordset rs3 = new ADODB.Recordset();

            try
            {
                //Recordset

                cn.Open(cnStr);

                rs1.Open("Select * From selldirect where period =" + cB + "and article =" + 1, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Select * From selldirect where period =" + cB + "and article =" + 2, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs3.Open("Select * From selldirect where period =" + cB + "and article =" + 3, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                while (!rs1.EOF)
                {
                    rs1.Fields["quantity"].Value = tBP1.Text;
                    rs1.Fields["price"].Value = tBP1P.Text;
                    rs1.Fields["penalty"].Value = tBP1S.Text;
                    rs1.MoveNext();

                }
                while (!rs2.EOF)
                {
                    rs2.Fields["quantity"].Value = tBP2.Text;
                    rs2.Fields["price"].Value = tBP2P.Text;
                    rs2.Fields["penalty"].Value = tBP2S.Text;
                    rs2.MoveNext();

                }
                while (!rs3.EOF)
                {
                    rs3.Fields["quantity"].Value = tBP3.Text;
                    rs3.Fields["price"].Value = tBP3P.Text;
                    rs3.Fields["penalty"].Value = tBP3S.Text;
                    rs3.MoveNext();
                }

            }
            catch (Exception)
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Fehler bei der Eingabe" : "Error in input";
                MessageBox.Show(LadeError);
            }
            finally
            {
                rs1.Close();
                rs2.Close();
                rs3.Close();
                cn.Close();
            }

            initalizeNumbers(aktuellePeriode);
            fillTextboxes();
            weiterButtonDispo.SelectedIndex = 2;
        }

        /// <summary>
        /// Eingaben aus Bedarfsplanung Tab in DB schreiben
        /// </summary>
        private void weiterButton3_Click_1(object sender, EventArgs e)
        {

            for (int row = 0; row < P1TextBoxes.GetLength(1); row++)
            {
                if(P1TextBoxes[2, row].Text == null ||Convert.ToInt32(P1TextBoxes[2,row].Text) < 0)
                {

                    string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Falsche Eingabe!" : "False input!";
                    MessageBox.Show(LadeError);
                    return;
                }
                if (P2TextBoxes[2, row].Text == null || Convert.ToInt32(P2TextBoxes[2, row].Text) < 0)
                {

                    string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Falsche Eingabe!" : "False input!";
                    MessageBox.Show(LadeError);
                    return;
                }
                if (P3TextBoxes[2, row].Text == null || Convert.ToInt32(P3TextBoxes[2, row].Text) < 0)
                {
                    string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Falsche Eingabe!" : "False input!";
                    MessageBox.Show(LadeError);
                    return;
                }
            }

                readyBedarf = true;
            saveButtonVisible();

            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            cn.Open(cnStr);
            int period = Convert.ToInt32(periodenLabel1.Text);
            rs.Open("Select * From GeplanterBedarf where period =" + period + "", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            try
            {
                if (rs.EOF)
                {
                    for (int row = 0; row < P1TextBoxes.GetLength(1); row++)
                    {
                        int item = P1Produkte[row];
                        int amountAP = Convert.ToInt32(P1TextBoxes[2, row].Text);
                        int productionPlan = Convert.ToInt32(P1TextBoxes[6, row].Text);

                        int item2 = P2Produkte[row];
                        int amountAP2 = Convert.ToInt32(P2TextBoxes[2, row].Text);
                        int productionPlan2 = Convert.ToInt32(P2TextBoxes[6, row].Text);

                        int item3 = P3Produkte[row];
                        int amountAP3 = Convert.ToInt32(P3TextBoxes[2, row].Text);
                        int productionPlan3 = Convert.ToInt32(P3TextBoxes[6, row].Text);

                        if (item == item2 && item == item3)
                        {
                            rs.AddNew();
                            int amountAPSum = amountAP + amountAP2 + amountAP3;
                            int productionPlanSum = productionPlan + productionPlan2 + productionPlan3;
                            rs.Fields["period"].Value = period;
                            rs.Fields["item"].Value = item;
                            rs.Fields["amountAfterPeriod"].Value = amountAPSum;
                            rs.Fields["productionPlan"].Value = productionPlanSum;
                        }
                        else
                        {

                            rs.AddNew();
                            rs.Fields["period"].Value = period;
                            rs.Fields["item"].Value = item;
                            rs.Fields["amountAfterPeriod"].Value = amountAP;
                            rs.Fields["productionPlan"].Value = productionPlan;

                            rs.AddNew();
                            rs.Fields["period"].Value = period;
                            rs.Fields["item"].Value = item2;
                            rs.Fields["amountAfterPeriod"].Value = amountAP2;
                            rs.Fields["productionPlan"].Value = productionPlan2;

                            rs.AddNew();
                            rs.Fields["period"].Value = period;
                            rs.Fields["item"].Value = item3;
                            rs.Fields["amountAfterPeriod"].Value = amountAP3;
                            rs.Fields["productionPlan"].Value = productionPlan3;
                        }
                    }

                    rs.Update();

                }
                else
                {
                    while (!rs.EOF)
                    {
                        int item = Convert.ToInt32(rs.Fields["item"].Value);
                        if (P1Produkte.Contains(item) && P2Produkte.Contains(item) && P3Produkte.Contains(item))
                        {
                            int amountSum = Convert.ToInt32(P1TextBoxes[2, Array.IndexOf(P1Produkte, item)].Text) + Convert.ToInt32(P2TextBoxes[2, Array.IndexOf(P2Produkte, item)].Text) + Convert.ToInt32(P3TextBoxes[2, Array.IndexOf(P3Produkte, item)].Text);
                            int productionSum = Convert.ToInt32(P1TextBoxes[6, Array.IndexOf(P1Produkte, item)].Text) + Convert.ToInt32(P2TextBoxes[6, Array.IndexOf(P2Produkte, item)].Text) + Convert.ToInt32(P3TextBoxes[6, Array.IndexOf(P3Produkte, item)].Text);
                            rs.Fields["amountAfterPeriod"].Value = amountSum;
                            rs.Fields["productionPlan"].Value = productionSum;
                        }
                        else if (P1Produkte.Contains(item))
                        {
                            rs.Fields["amountAfterPeriod"].Value = Convert.ToInt32(P1TextBoxes[2, Array.IndexOf(P1Produkte, item)].Text);
                            rs.Fields["productionPlan"].Value = Convert.ToInt32(P1TextBoxes[6, Array.IndexOf(P1Produkte, item)].Text);
                        }

                        else if (P2Produkte.Contains(item))
                        {
                            rs.Fields["amountAfterPeriod"].Value = Convert.ToInt32(P2TextBoxes[2, Array.IndexOf(P2Produkte, item)].Text);
                            rs.Fields["productionPlan"].Value = Convert.ToInt32(P2TextBoxes[6, Array.IndexOf(P2Produkte, item)].Text);
                        }

                        else if (P3Produkte.Contains(item))
                        {
                            rs.Fields["amountAfterPeriod"].Value = Convert.ToInt32(P3TextBoxes[2, Array.IndexOf(P3Produkte, item)].Text);
                            rs.Fields["productionPlan"].Value = Convert.ToInt32(P3TextBoxes[6, Array.IndexOf(P3Produkte, item)].Text);
                        }
                        rs.MoveNext();
                    }
                    rs.Close();

                }
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine(fe.Message);

            }
            cn.Close();

            if(aktuellePeriode == 1)
            Datagrid_leeren_befüllen(true, true);
            else
            Datagrid_leeren_befüllen(true, false);

            weiterButtonDispo.SelectedIndex = 3;
        }
        private void initializeTextboxes()
        {
            P1TextBoxes = initializeTextboxList(0);
            P2TextBoxes = initializeTextboxList(1);
            P3TextBoxes = initializeTextboxList(2);
        }

        private TextBox[,] initializeTextboxList(int v)
        {
            TextBox[,] TBListe = new TextBox[7, 12];
            TabPage t = metroTabControl2.TabPages[v];

            int[] fillableRows = { 1, 3, 4, 6, 7, 8, 10, 11, 12, 14, 15, 16 };
            int[] columns = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (Control c in t.Controls)
            {
                if (c is TableLayoutPanel)
                {
                    TableLayoutPanel table = (TableLayoutPanel)c;
                    foreach (int row in fillableRows)
                    {
                        foreach (int column in columns)
                        {
                            TextBox tb = new TextBox();
                            tb.LostFocus += new System.EventHandler(anyTextboxChanged);
                            if (column == 1 && row == 1)
                            {
                                tb.Text = "";
                            }
                            tb.TabStop = false;
                            tb.ReadOnly = true;

                            TBListe[Array.IndexOf(columns, column), Array.IndexOf(fillableRows, row)] = tb;
                            table.Controls.Add(tb, column, row);
                        }
                    }
                }
            }
            return TBListe;
        }
        /// <summary>
        /// Inhalt der Textboxen aktualisieren
        /// </summary>
        private void anyTextboxChanged(object sender, EventArgs e)
        {
            refillTextboxes();
        }
        private void refillTextboxes()
        {
            fillOneTextboxList(P1TextBoxes, sellwishList[0, 0], P1LagerstandVP, P1LagerstandAP, P1Warteschlange, P1WarteschlangeArbeitsplatz, P1Bearbeitung, P1GeplanterBedarfVP, false);
            fillOneTextboxList(P2TextBoxes, sellwishList[0, 1], P2LagerstandVP, P2LagerstandAP, P2Warteschlange, P2WarteschlangeArbeitsplatz, P2Bearbeitung, P2GeplanterBedarfVP, false);
            fillOneTextboxList(P3TextBoxes, sellwishList[0, 2], P3LagerstandVP, P3LagerstandAP, P3Warteschlange, P3WarteschlangeArbeitsplatz, P3Bearbeitung, P3GeplanterBedarfVP, false);
        }
        private void fillTextboxes()
        {
            fillOneTextboxList(P1TextBoxes, sellwishList[0, 0], P1LagerstandVP, P1LagerstandAP, P1Warteschlange, P1WarteschlangeArbeitsplatz, P1Bearbeitung, P1GeplanterBedarfVP, true);
            fillOneTextboxList(P2TextBoxes, sellwishList[0, 1], P2LagerstandVP, P2LagerstandAP, P2Warteschlange, P2WarteschlangeArbeitsplatz, P2Bearbeitung, P2GeplanterBedarfVP, true);
            fillOneTextboxList(P3TextBoxes, sellwishList[0, 2], P3LagerstandVP, P3LagerstandAP, P3Warteschlange, P3WarteschlangeArbeitsplatz, P3Bearbeitung, P3GeplanterBedarfVP, true);
        }
        private void initalizeNumbers(int currentPeriod)
        {
            geladenePeriode = currentPeriod;

            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rsSW = new ADODB.Recordset();
            ADODB.Recordset rsSD = new ADODB.Recordset();
            ADODB.Recordset rsWH = new ADODB.Recordset();
            ADODB.Recordset rsOW = new ADODB.Recordset();
            ADODB.Recordset rsWL = new ADODB.Recordset();
            ADODB.Recordset rsWW = new ADODB.Recordset();
            ADODB.Recordset rsGB = new ADODB.Recordset();
            ADODB.Recordset rsGBVP = new ADODB.Recordset();

            cn.Open(cnStr);

            int vorperiode = currentPeriod - 1;

            rsSW.Open("Select * From sellwish where planPeriod = " + currentPeriod + " order by period", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsSD.Open("Select * From selldirect where period = " + currentPeriod + " order by period", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsWH.Open("Select * From warehousestock_article where period ='" + vorperiode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsOW.Open("Select * From ordersinwork where period ='" + vorperiode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsWL.Open("Select * From waitingliststock where period =" + vorperiode + "", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsWW.Open("Select * From waitinglistworkstations where period ='" + vorperiode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsGB.Open("Select * From GeplanterBedarf where period =" + currentPeriod + "", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsGBVP.Open("Select * From GeplanterBedarf where period =" + vorperiode + "", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            sellwishList = new int[4, 3];
            while (!rsSW.EOF)
            {
                sellwishList[Convert.ToInt32(rsSW.Fields["period"].Value) - currentPeriod, Convert.ToInt32(rsSW.Fields["article"].Value) - 1] = rsSW.Fields["quantity"].Value;
                rsSW.MoveNext();

            }

            while (!rsSD.EOF)
            {
                int x = Convert.ToInt32(rsSD.Fields["period"].Value) - currentPeriod;
                int y = Convert.ToInt32(rsSD.Fields["article"].Value) - 1;
                sellwishList[x, y] += rsSD.Fields["quantity"].Value;
                rsSD.MoveNext();
            }

            P1LagerstandVP = new int?[P1Produkte.Length];
            P2LagerstandVP = new int?[P2Produkte.Length];
            P3LagerstandVP = new int?[P3Produkte.Length];

            P1LagerstandAP = new int?[P1Produkte.Length];
            P2LagerstandAP = new int?[P2Produkte.Length];
            P3LagerstandAP = new int?[P3Produkte.Length];

            P1GeplanterBedarfVP = new int?[P1Produkte.Length];
            P2GeplanterBedarfVP = new int?[P2Produkte.Length];
            P3GeplanterBedarfVP = new int?[P3Produkte.Length];

            P1Warteschlange = new int?[P1Produkte.Length];
            P2Warteschlange = new int?[P2Produkte.Length];
            P3Warteschlange = new int?[P3Produkte.Length];

            P1WarteschlangeArbeitsplatz = new int?[P1Produkte.Length];
            P2WarteschlangeArbeitsplatz = new int?[P2Produkte.Length];
            P3WarteschlangeArbeitsplatz = new int?[P3Produkte.Length];

            P1Bearbeitung = new int?[P1Produkte.Length];
            P2Bearbeitung = new int?[P2Produkte.Length];
            P3Bearbeitung = new int?[P3Produkte.Length];

            while (!rsWH.EOF)
            {
                int id = Convert.ToInt32(rsWH.Fields["id"].Value);
                int amount = Convert.ToInt32(rsWH.Fields["amount"].Value);
                if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                {
                    amount = amount / 3;
                }

                inListeEintragen(id, amount, P1LagerstandVP, P2LagerstandVP, P3LagerstandVP, false);

                rsWH.MoveNext();
            }

            while (!rsWL.EOF)
            {
                int id = Convert.ToInt32(rsWL.Fields["item"].Value);
                int amount = Convert.ToInt32(rsWL.Fields["amount"].Value);
                if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                {
                    amount = amount / 3;
                }

                inListeEintragen(id, amount, P1Warteschlange, P2Warteschlange, P3Warteschlange, true);

                rsWL.MoveNext();
            }

            while (!rsWW.EOF)
            {
                if (!DBNull.Value.Equals(rsWW.Fields["item"].Value) && !DBNull.Value.Equals(rsWW.Fields["amount"].Value))
                {
                    int id = Convert.ToInt32(rsWW.Fields["item"].Value);
                    int amount = Convert.ToInt32(rsWW.Fields["amount"].Value);
                    if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                    {
                        amount = amount / 3;
                    }

                    inListeEintragen(id, amount, P1WarteschlangeArbeitsplatz, P2WarteschlangeArbeitsplatz, P3WarteschlangeArbeitsplatz, true);
                }
                rsWW.MoveNext();
            }

            while (!rsOW.EOF)
            {
                int id = Convert.ToInt32(rsOW.Fields["item"].Value);
                int amount = Convert.ToInt32(rsOW.Fields["amount"].Value);
                if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                {
                    amount = amount / 3;
                }

                inListeEintragen(id, amount, P1Bearbeitung, P2Bearbeitung, P3Bearbeitung, true);

                rsOW.MoveNext();
            }

            while (!rsGB.EOF)
            {
                int id = Convert.ToInt32(rsGB.Fields["item"].Value);
                int amount = Convert.ToInt32(rsGB.Fields["amountAfterPeriod"].Value);
                if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                {
                    amount = amount / 3;
                }

                inListeEintragen(id, amount, P1LagerstandAP, P2LagerstandAP, P3LagerstandAP, false);

                rsGB.MoveNext();
            }

            while (!rsGBVP.EOF)
            {
                int id = Convert.ToInt32(rsGBVP.Fields["item"].Value);
                int amount = Convert.ToInt32(rsGBVP.Fields["amountAfterPeriod"].Value);
                if (P1Produkte.Contains(id) && P2Produkte.Contains(id) && P3Produkte.Contains(id))
                {
                    amount = amount / 3;
                }

                inListeEintragen(id, amount, P1GeplanterBedarfVP, P2GeplanterBedarfVP, P3GeplanterBedarfVP, false);

                rsGBVP.MoveNext();
            }

            rsSW.Close();
            rsSD.Close();
            rsWH.Close();
            rsOW.Close();
            rsWL.Close();
            rsWW.Close();
            rsGB.Close();
            rsGBVP.Close();
            cn.Close();
        }
        private void inListeEintragen(int id, int amount, int?[] p1Liste, int?[] p2Liste, int?[] p3Liste, Boolean addValue)
        {
            if (P1Produkte.Contains(id))
            {
                int stelle = Array.IndexOf(P1Produkte, id);
                if (p1Liste[stelle] == null)
                    p1Liste[stelle] = amount;
                else
                    p1Liste[stelle] += amount;

            }
            if (P2Produkte.Contains(id))
            {
                int stelle = Array.IndexOf(P2Produkte, id);
                if (p2Liste[stelle] == null)
                    p2Liste[stelle] = amount;
                else
                    p2Liste[stelle] += amount;
            }
            if (P3Produkte.Contains(id))
            {
                int stelle = Array.IndexOf(P3Produkte, id);
                if (p3Liste[stelle] == null)
                    p3Liste[stelle] = amount;
                else
                    p3Liste[stelle] += amount;
            }
        }


        private void fillOneTextboxList(TextBox[,] textBox, int firstValue, int?[] lagerList, int?[] lagerListAp, int?[] warteschlange, int?[] warteschlangeArbeitsplatz, int?[] bearbeitung, int?[] geplanterBedarf, bool firstCall)
        {
            int value = firstValue;
            int bothWarteschlangenLastValue = 0;
            try
            {
                for (int row = 0; row < textBox.GetLength(1); row++)
                {
                    textBox[0, row].Text = value.ToString();
                    if (row != 0)
                    {
                        textBox[1, row].Text = bothWarteschlangenLastValue.ToString();
                    }

                    int editableValue = 0;

                    if (geladenePeriode == aktuellePeriode)
                    {
                        textBox[2, row].ReadOnly = false;
                        textBox[2, row].TabStop = true;
                        textBox[2, row].TabIndex = row;
                    }
                    else
                    {
                        textBox[2, row].TabStop = false;
                        textBox[2, row].ReadOnly = true;
                    }

                    if (firstCall)
                    {
                        if (lagerList[row] != null)
                        {
                            editableValue = Convert.ToInt32(lagerList[row]);
                        }
                        if (geplanterBedarf[row] != null)
                        {
                            editableValue = Convert.ToInt32(geplanterBedarf[row]);
                        }
                        if (lagerListAp[row] != null)
                        {
                            editableValue = Convert.ToInt32(lagerListAp[row]);
                        }
                    }
                    else if (textBox[2, row].Text != "")
                    {
                        if (Convert.ToInt32(textBox[2, row].Text) < 0)
                        {
                            throw new FormatException("Es wurden fälschlicherweise negative Werte eingetragen.");
                        }
                        editableValue = Convert.ToInt32(textBox[2, row].Text);
                    }
                    textBox[2, row].Text = editableValue.ToString();

                    textBox[3, row].Text = lagerList[row].ToString();

                    int wartschlangeValue = Convert.ToInt32(warteschlange[row]);
                    int wartschlangeArbeitsplatzValue = Convert.ToInt32(warteschlangeArbeitsplatz[row]);
                    int bothWarteschlangenValue = wartschlangeValue + wartschlangeArbeitsplatzValue;
                    textBox[4, row].Text = bothWarteschlangenValue.ToString();

                    int beartbeitungsValue = Convert.ToInt32(bearbeitung[row]);

                    int lastvalue = value + bothWarteschlangenLastValue + editableValue - Convert.ToInt32(lagerList[row]) - bothWarteschlangenValue - beartbeitungsValue;
                    bool negative = (lastvalue < 0);
                    if (negative)
                    {
                        editableValue = editableValue + (lastvalue * (-1));
                        textBox[2, row].Text = editableValue.ToString();
                        lastvalue = 0;
                    }
                    if (rowsForWaitingList.Contains(row))
                    {
                        bothWarteschlangenLastValue = bothWarteschlangenValue;
                        value = lastvalue;
                    }

                    textBox[5, row].Text = beartbeitungsValue.ToString();
                    textBox[6, row].Text = lastvalue.ToString();


                }
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine(fe.Message);

            }
        }
        /// <summary>
        /// Rollback Button für Abbruch der Planung
        /// </summary>
        private void rollbackButton_Click(object sender, EventArgs e)
        {
            rollback();
            MessageBox.Show("Bisherige Planung wurde erfolgreich zurückgesetzt!");
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void rollback()
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            cn.Open(cnStr);
            try
            {
                rs.Open("Select distinct period from summary ORDER BY period Desc", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                int aktuellePlanPeriode = Convert.ToInt32(rs.Fields["period"].Value);
                aktuellePlanPeriode++;


                rs2.Open("Delete from Prognose where planperiod=" + aktuellePlanPeriode, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Delete from sellwish where planperiod=" + aktuellePlanPeriode, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Delete from selldirect where period=" + aktuellePlanPeriode, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Delete from productionlist where period=" + aktuellePlanPeriode, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs2.Open("Delete from myOrderlist where period=" + "'" + aktuellePlanPeriode + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            }
            catch (Exception){ }

                cn.Close();
        }

        /// <summary>
        /// DispositionsGrid befüllen
        /// </summary>
        public void Datagrid_leeren_befüllen(bool clear, bool initial)
        {
            //######################## Datagridview
            bool bestellungNotwendig = false;

            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            ADODB.Recordset rsLieferungen = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();

            //Connection öffnen
            cn.Open(cnStr);



            rs.Open("Select * From abf_Summe_Kaufteile_Gesamt WHERE planperiod =" + (aktuellePeriode), cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rsLieferungen.Open("Select * From abf_Lieferzeitpunkt_bestellte_ware_Kreuztabelle WHERE period ='" + (aktuellePeriode) + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            if(clear)
               dispoGrid.Rows.Clear();

            dispoGrid.Columns["Bestand_in_n"].HeaderText = "Bestand_in_" + (aktuellePeriode);
            dispoGrid.Columns["Bestand_in_n1"].HeaderText = "Bestand_in_" + (aktuellePeriode + 1);
            dispoGrid.Columns["Bestand_in_n2"].HeaderText = "Bestand_in_" + (aktuellePeriode + 2);
            dispoGrid.Columns["Bestand_in_n3"].HeaderText = "Bestand_in_" + (aktuellePeriode + 3);

            //dispoGrid.Columns["KommendeBestellung_n"].HeaderText = "KB_" + (aktuellePeriode);
            //dispoGrid.Columns["KommendeBestellung_n1"].HeaderText = "KB_" + (aktuellePeriode + 1);
            //dispoGrid.Columns["KommendeBestellung_n2"].HeaderText = "KB_" + (aktuellePeriode + 2);
            //dispoGrid.Columns["KommendeBestellung_n3"].HeaderText = "KB_" + (aktuellePeriode + 3);
            double anfangsBestand = 0;
            double bestand1 = 0;
            double bestand2 = 0;
            double bestand3 = 0;
            double bestand4 = 0;
            double bedarf1 = 0;
            double bedarf2 = 0;
            double bedarf3 = 0;
            double bedarf4 = 0;
            double lieferung1 = 0;
            double lieferung2 = 0;
            double lieferung3 = 0;
            double lieferung4 = 0;

            while (!rs.EOF)
            {

                if(clear)
                    dispoGrid.Rows.Add();
                if(initial)
                {
                    dispoGrid.Rows[i].Cells["Menge"].Value = 0;
                    dispoGrid.Rows[i].Cells["Bestellart"].Value = "N";
                }

                dispoGrid.Rows[i].Cells["Periode"].Value = Convert.ToInt32(rs.Fields["planPeriod"].Value);
                dispoGrid.Rows[i].Cells["Kaufteil"].Value = rs.Fields["Artikel"].Value;
                dispoGrid.Rows[i].Cells["Lieferfrist"].Value = rs.Fields["Lieferzeit"].Value;
                dispoGrid.Rows[i].Cells["Abweichung"].Value = rs.Fields["Lieferzeitabweichung"].Value;
                dispoGrid.Rows[i].Cells["Diskontmenge"].Value = rs.Fields["Diskontmenge"].Value;
                dispoGrid.Rows[i].Cells["Anfangsbestand_n"].Value = rs.Fields["amount"].Value;
                anfangsBestand = Convert.ToInt32(rs.Fields["amount"].Value);
                dispoGrid.Rows[i].Cells["Preis"].Value = rs.Fields["price"].Value;
                //dispoGrid.Rows[i].Cells["Bruttobedarf_n"].Value 
                bedarf1 = rs.Fields["AktuellePeriode"].Value;
                //dispoGrid.Rows[i].Cells["Bruttobedarf_n1"].Value 
                bedarf2 = rs.Fields[Convert.ToString(aktuellePeriode - 1 + 1)].Value;
                //dispoGrid.Rows[i].Cells["Bruttobedarf_n2"].Value 
                bedarf3 = rs.Fields[Convert.ToString(aktuellePeriode - 1 + 2)].Value;
                //dispoGrid.Rows[i].Cells["Bruttobedarf_n3"].Value 
                bedarf4 = rs.Fields[Convert.ToString(aktuellePeriode - 1 + 3)].Value;
                dispoGrid.Rows[i].Cells["Bestellkosten"].Value = rs.Fields["Lieferkosten"].Value;
                /* long myBruttebedarf_summe = Convert.ToInt32(dispoGrid.Rows[i].Cells["Bestand_in_n"].Value) + Convert.ToInt32(dispoGrid.Rows[i].Cells["Bestand_in_n1"].Value)
                     + Convert.ToInt32(dispoGrid.Rows[i].Cells["Bestand_in_n2"].Value) + Convert.ToInt32(dispoGrid.Rows[i].Cells["Bestand_in_n3"].Value);
                 long myJahresbaedarf = (myBruttebedarf_summe / 4) * 52;*/

                //Bestellvorschlag
                //dispoGrid.Rows[i].Cells["Bestellmenge"].Value = Math.Round(Math.Sqrt((200 * myJahresbaedarf * Convert.ToInt32(dispoGrid.Rows[i].Cells["Bestellkosten"].Value)) / (Convert.ToInt32(textBox1.Text) * Convert.ToDouble(dispoGrid.Rows[i].Cells["Preis"].Value))));



                double myPufferzeit = 1.3 + Convert.ToDouble(dispoGrid.Rows[i].Cells["Lieferfrist"].Value) + Convert.ToDouble(dispoGrid.Rows[i].Cells["Abweichung"].Value = rs.Fields["Lieferzeitabweichung"].Value);
                double myGanzePerioden = Math.Round(Math.Floor(myPufferzeit));
                double myZehntelPerioden = Math.Round((myPufferzeit - myGanzePerioden) * 10);
                int j = 0;
                double myPufferbedarf = 0;

                // Artikel in Der Tabelle Lieferzeitpunkt bestellte ware suchen

                if (!initial)
                {
                    rsLieferungen.MoveFirst();
                    while (!rsLieferungen.EOF)
                    {
                        if (rsLieferungen.Fields["article"].Value.Equals(Convert.ToInt32(rs.Fields["Artikel"].Value)))
                        { break; }
                        rsLieferungen.MoveNext();
                    }

                    if (!rsLieferungen.EOF)
                    {
                        int aktuellePeriode1 = aktuellePeriode + 1;
                        int aktuellePeriode2 = aktuellePeriode + 2;
                        int aktuellePeriode3 = aktuellePeriode + 3;
                        try
                        { //dispoGrid.Rows[i].Cells["KommendeBestellung_n"].Value 
                           // if (DBNull.Value.Equals(rsLieferungen.Fields[aktuellePeriode]))
                                lieferung1 = Convert.ToInt32(rsLieferungen.Fields[aktuellePeriode].Value);
                        }
                        catch (Exception ) { }
                        try
                        { //dispoGrid.Rows[i].Cells["KommendeBestellung_n1"].Value 
                          // if (DBNull.Value.Equals(rsLieferungen.Fields[aktuellePeriode1]))
                                lieferung2 = Convert.ToInt32(rsLieferungen.Fields[aktuellePeriode1].Value);
                        }
                        catch (Exception ) {  }
                        try
                        { //dispoGrid.Rows[i].Cells["KommendeBestellung_n2"].Value 
                          //if (DBNull.Value.Equals(rsLieferungen.Fields[aktuellePeriode2]))
                                lieferung3 = Convert.ToInt32(rsLieferungen.Fields[aktuellePeriode2].Value);
                        }
                        catch (Exception) { }
                        try
                        { //dispoGrid.Rows[i].Cells["KommendeBestellung_n3"].Value 
                           // if (DBNull.Value.Equals(rsLieferungen.Fields[aktuellePeriode3]))
                                lieferung4 = Convert.ToInt32(rsLieferungen.Fields[Convert.ToString(aktuellePeriode3)].Value);
                        }
                        catch (Exception) { }
                    }
                }

                /// <summary>
                /// Bedarf wird mit Beständen und Lieferungen verrechnet
                /// </summary>
                bestand1 = anfangsBestand - bedarf1 + lieferung1;
                bestand2 = bestand1 - bedarf2 + lieferung2;
                bestand3 = bestand2 - bedarf3 + lieferung3;
                bestand4 = bestand3 - bedarf4 + lieferung4;

                dispoGrid.Rows[i].Cells["Bestand_in_n"].Value = bestand1;
                dispoGrid.Rows[i].Cells["Bestand_in_n1"].Value = bestand2;
                dispoGrid.Rows[i].Cells["Bestand_in_n2"].Value = bestand3;
                dispoGrid.Rows[i].Cells["Bestand_in_n3"].Value = bestand4;

                ADODB.Recordset rsBedarf = new ADODB.Recordset();
                string artikelNummer = Convert.ToString(dispoGrid.Rows[i].Cells["Kaufteil"].Value);
                int period;
                int lieferperiode;
                int lieferzeit;
                rsBedarf.Open("Select period, Lieferperiode From abf_Lieferzeitpunkt_bestellte_ware WHERE article =" + artikelNummer, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                try
                {
                    if (rsBedarf.Fields["period"].Value == null)
                        period = aktuellePeriode;
                    else
                        period =Convert.ToInt32(rsBedarf.Fields["period"].Value);
                    if (rsBedarf.Fields["Lieferperiode"].Value == null)
                        lieferperiode = aktuellePeriode;
                    else
                         lieferperiode = Convert.ToInt32(rsBedarf.Fields["Lieferperiode"].Value);

                    lieferzeit = lieferperiode - period;
                    if(lieferzeit == 0  && bestand1 < 0)
                    {
                        bestellungNotwendig = true;
                    }
                    if (lieferzeit == 1 && (bestand2 < 0 || bestand1  < 0))
                    {
                        bestellungNotwendig = true;
                    }
                    if (lieferzeit == 2 && (bestand2 < 0 || bestand1 < 0 || bestand3 < 0))
                    {
                        bestellungNotwendig = true;
                    }
                    if (lieferzeit == 3 && (bestand2 < 0 || bestand1 < 0 || bestand3 < 0 || bestand4 < 0))
                    {
                        bestellungNotwendig = true;
                    }
                }
                catch (Exception) { }
                if(bestellungNotwendig)
                {
                    dispoGrid.Rows[i].Cells["Menge"].Style.BackColor = Color.Red;
                }
                else
                {
                    dispoGrid.Rows[i].Cells["Menge"].Style.BackColor = Color.Silver;
                }
                bestellungNotwendig = false;
                rsBedarf.Close();

                lieferung1 = 0;
                lieferung2 = 0;
                lieferung3 = 0;
                lieferung4 = 0;
                //Überprüfen ob bestellt werden muss
                /*
                while (j < myGanzePerioden)
                {
                    if (j > 4) { myPufferbedarf = myPufferbedarf + myBruttebedarf_summe / 4; }
                    else
                    {
                        if (j == 0) myPufferbedarf = myPufferbedarf + Convert.ToDouble(rs.Fields["AktuellePeriode"].Value);
                        else myPufferbedarf = myPufferbedarf + Convert.ToDouble(rs.Fields[Convert.ToString(aktuellePeriode - 1 + j)].Value);
                        try
                        {
                            if (!DBNull.Value.Equals(rsLieferungen.Fields[Convert.ToString(aktuellePeriode - 1 + j)].Value))
                                if (!rsLieferungen.EOF) myPufferbedarf = myPufferbedarf - rsLieferungen.Fields[Convert.ToString(aktuellePeriode - 1 + j)].Value;
                        }
                        catch (System.Runtime.InteropServices.COMException) { }
                    }
                    if (myPufferbedarf > Convert.ToInt32(dispoGrid.Rows[i].Cells["Anfangsbestand_n"].Value))
                    {
                        dispoGrid.Rows[i].Cells["Bestellart"].Value = "N";
                        dispoGrid.Rows[i].Cells["Kaufteil"].Style.BackColor = Color.Red;
                        if (j < 5) dispoGrid[12 + j, i].Style.BackColor = Color.Red;
                    }
                    else if (j < 5)
                    {
                        dispoGrid[12 + j, i].Style.BackColor = Color.Green;
                    }




                    ++j;
                }

                if (j > 3) { myPufferbedarf = myPufferbedarf + ((myBruttebedarf_summe / 4) / 10) * myZehntelPerioden; }
                else myPufferbedarf = myPufferbedarf + Convert.ToDouble(rs.Fields[Convert.ToString(aktuellePeriode - 1 + j)].Value / 10) * myZehntelPerioden;

                if (myPufferbedarf > Convert.ToInt32(dispoGrid.Rows[i].Cells["Anfangsbestand_n"].Value))
                {
                    dispoGrid.Rows[i].Cells["Bestellart"].Value = "N";
                    if (dispoGrid.Rows[i].Cells["Kaufteil"].Style.BackColor != Color.Red)
                        dispoGrid.Rows[i].Cells["Kaufteil"].Style.BackColor = Color.Yellow;
                    if (j < 4) dispoGrid[12 + j, i].Style.BackColor = Color.Red;


                }
                else if (j < 4) dispoGrid[12 + j, i].Style.BackColor = Color.Green;

    */
                rs2.Open("SELECT * FROM myOrderlist WHERE period = '" + aktuellePeriode + "';", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                if (!rs2.EOF)
                {
                    bool gefunden = false;
                    while (!rs2.EOF)
                    {
                        if (dispoGrid.Rows[i].Cells["Kaufteil"].Value.Equals(Convert.ToInt32(rs2.Fields["article"].Value)))
                        {
                            string mymodus = "";
                            if (Convert.ToInt32(rs2.Fields["modus"].Value) == 5) mymodus = "N";
                            if (Convert.ToInt32(rs2.Fields["modus"].Value) == 4) mymodus = "E";
                            dispoGrid.Rows[i].Cells["Bestellart"].Value = mymodus;
                            dispoGrid.Rows[i].Cells["Menge"].Value = rs2.Fields["quantity"].Value;
                            gefunden = true;
                        }
                        rs2.MoveNext();
                    }
                    if (!gefunden)
                    {
                        dispoGrid.Rows[i].Cells["Bestellart"].Value = "";
                        dispoGrid.Rows[i].Cells["Menge"].Value = "";
                    }
                }
                rs2.Close();


                rs.MoveNext();
                ++i;
            }

            rs.Close();
            rsLieferungen.Close();
            cn.Close();
        }

        private void weiterButton4_Click(object sender, EventArgs e)
        {
            readyDispo = true;
            saveButtonVisible();



            for (int j = 0; j < dispoGrid.RowCount; ++j)
            {
                if (dispoGrid["Bestellart", j].Value != null)
                {
                    if (dispoGrid["Menge", j].Value == null || Convert.ToInt32(dispoGrid["Menge", j].Value) < 0)
                    {
                        MessageBox.Show("Falsche eingegeben!");
                        return;
                    }
                }
            }



            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();


            cn.Open(cnStr);

            rs.Open("DELETE * FROM myOrderlist WHERE period = '" + aktuellePeriode + "';", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            rs.Open("SELECT Max([period]) AS maxPeriod FROM myOrderlist;", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            if (Convert.ToInt32(rs.Fields["maxPeriod"].Value) == aktuellePeriode) { MessageBox.Show("Diese Periode ist bereits geplant!"); }
            else
            {
                rs.Close();
                rs.Open("SELECT * FROM myOrderlist;", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                for (int i = 0; i < dispoGrid.RowCount; ++i)
                {
                    if (dispoGrid["Bestellart", i].Value != null)
                    {
                        if (dispoGrid["Bestellart", i].Value.Equals("N"))
                        {
                            rs.AddNew();
                            rs.Fields["period"].Value = aktuellePeriode;
                            rs.Fields["article"].Value = dispoGrid["Kaufteil", i].Value;
                            rs.Fields["quantity"].Value = dispoGrid["Menge", i].Value;
                            rs.Fields["modus"].Value = "5";
                        }

                        else if (dispoGrid["Bestellart", i].Value.Equals("E"))
                        {
                            rs.AddNew();
                            rs.Fields["period"].Value = aktuellePeriode;
                            rs.Fields["article"].Value = dispoGrid["Kaufteil", i].Value;
                            rs.Fields["quantity"].Value = dispoGrid["Menge", i].Value;
                            rs.Fields["modus"].Value = "4";
                        }
                    }
                }
                rs.Update();
            }



            rs.Close();
            cn.Close();
            LoadProdPlan();
            weiterButtonDispo.SelectedIndex = 4;


        }

        private void dispoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            //if (Convert.ToString(dispoGrid["Bestellart", e.RowIndex].Value) == "N" || Convert.ToString(dispoGrid["Bestellart", e.RowIndex].Value) == "E")
            //{

                //Recordset
                ADODB.Connection cn = new ADODB.Connection();
                ADODB.Recordset rs = new ADODB.Recordset();


                cn.Open(cnStr);
                rs.Open("DELETE * FROM futureinwardstockmovement WHERE period = '" + aktuellePeriode + "';", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.Open("SELECT * FROM futureinwardstockmovement;", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                for (int i = 0; i < dispoGrid.RowCount; ++i)
                {
                    if (Convert.ToString(dispoGrid["Bestellart", i].Value) != "")
                    {
                        rs.AddNew();
                        rs.Fields["id"].Value = Convert.ToString(i);
                        rs.Fields["period"].Value = aktuellePeriode;
                        rs.Fields["orderperiod"].Value = aktuellePeriode;
                        rs.Fields["article"].Value = dispoGrid["Kaufteil", i].Value;
                        rs.Fields["amount"].Value = dispoGrid["Menge", i].Value;
                        rs.Fields["mode"].Value = dispoGrid["Bestellart", i].Value; ;
                    }



                }

                rs.Update();

                rs.Close();
                cn.Close();
                Datagrid_leeren_befüllen(false, false);

            }
        //}

        public void saveButtonVisible()
        {
            bool saveVisible = false;
            if (readyBedarf && readyDirektbezug && readyDispo && readyKapa && readyProduktion && readyPrognose)
            {
                saveVisible = true;
            }
            if (saveVisible)
            {
                saveButton.Visible = true;
            }
            else {
                saveButton.Visible = false;
            }
        }


        //Prod Planung
        private void LoadProdPlan()
        {
            metroGrid1.Rows.Clear();
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
           
            cn.Open(cnStr);
            int cB = aktuellePeriode;
            rs.Open("Select * From productionlist where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["article"].Value = rs.Fields["article"].Value;
                metroGrid1.Rows[i].Cells["quantity"].Value = rs.Fields["quantity"].Value;
                rs.MoveNext();
                ++i;
            }
            rs.Close();
            cn.Close();
            SaveProdPlan(false);
        }
        private void SaveProdPlan(bool pruefen)
        {
                //Recordset
                ADODB.Connection cn = new ADODB.Connection();
                ADODB.Recordset rs = new ADODB.Recordset();
                ADODB.Recordset rs1 = new ADODB.Recordset();
                ADODB.Recordset rs2 = new ADODB.Recordset();
             
                cn.Open(cnStr);
            int cB = aktuellePeriode;
                try
                {
                    rs.Open("Delete * From productionlist where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    foreach (DataGridViewRow row in metroGrid1.Rows)
                    {
                        int a = Convert.ToInt32(row.Cells["article"].Value);
                        int b = Convert.ToInt32(row.Cells["quantity"].Value);
                        rs1.Open("Insert into productionlist (article, quantity, period) values (" + a + "," + b + "," + cB + ")", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    }
                    rs2.Open("Delete * From productionlist where period =" + cB + " and article = 0", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                }
                catch (Exception test)
                {
                    string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Fehler bei der Verarbeitung" : "Error processing";
                    MessageBox.Show(LadeError);

                }
                finally
                {
                    cn.Close();
                }
                 if(!pruefen)
                  Pruefen1();
           

        }
        //dispoGrid.Rows[i].Cells["Menge"].Style.BackColor = Color.Red;
        public void Pruefen1()
        {
           
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            ADODB.Recordset rs3 = new ADODB.Recordset();
            
            cn.Open(cnStr);
            int cB = aktuellePeriode;
            rs.Open("Select * From Produktionsprogramm where period =" + cB + " and Ausdr1 <> 0", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rs2.Open("Select * From Produktionsprogramm2 where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rs3.Open("Select * From Produktionsprogramm3 where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int i = 0;

            while (!rs3.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["article"].Style.BackColor = Color.Red;
                metroGrid1.Rows[i].Cells["quantity"].Style.BackColor = Color.Red;
                ++i;
                rs3.MoveNext();
            }
            while (!rs2.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["article"].Style.BackColor = Color.Red;
                metroGrid1.Rows[i].Cells["quantity"].Style.BackColor = Color.Red;
                ++i;
                rs2.MoveNext();
            }

            while (!rs.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[i].Cells["article"].Style.BackColor = Color.Red;
                metroGrid1.Rows[i].Cells["quantity"].Style.BackColor = Color.Red;
                ++i;
                if (rs.Fields["Ausdr1"].Value == 0) { rs.MoveNext(); }
                else
                {
                    prüfung = false;
                    rs.MoveNext();
                }
            }
            rs.Close();
            rs2.Close();
            rs3.Close();
            cn.Close();
            
        }

        public void Pruefen2()
        {
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs2 = new ADODB.Recordset();
           
            cn.Open(cnStr);

            int cB = aktuellePeriode;
        rs2.Open("Select * From GeplanterBedarf where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
            int kkk = 0;
            while (!rs2.EOF)
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[kkk].Cells["article"].Style.BackColor = Color.Red;
                metroGrid1.Rows[kkk].Cells["quantity"].Style.BackColor = Color.Red;
                rs2.MoveNext();
                kkk++;
            }

        }

        public void StartProdPlanung()
        {
           metroGrid1.Rows.Clear();
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;

            //Connection string.
            cnStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= PPS-Datenbank_2.mdb";
            cn.Open(cnStr);
            int cB = aktuellePeriode;
            rs.Open("Select * From GeplanterBedarf where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
               metroGrid1.Rows.Add();
               metroGrid1.Rows[i].Cells["article"].Value = rs.Fields["item"].Value;
               metroGrid1.Rows[i].Cells["qunatity"].Value = rs.Fields["productionPlan"].Value;
                rs.MoveNext();
                ++i;
            }
            rs.Close();
            cn.Close();
        }

        private void planButton_Click(object sender, EventArgs e)
        {

            SaveProdPlan(true);
            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
          
            cn.Open(cnStr);
            int cB = aktuellePeriode;
            rs.Open("Select * From GeplanterBedarf where period =" + cB, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

            int i = 0;

            while (!rs.EOF)
            {
               metroGrid1.Rows.Add();
               metroGrid1.Rows[i].Cells["article"].Value = rs.Fields["item"].Value;
               metroGrid1.Rows[i].Cells["quantity"].Value = rs.Fields["productionPlan"].Value;
                rs.MoveNext();
                ++i;
            }
            rs.Close();
            cn.Close();
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void weiterButton5_Click(object sender, EventArgs e)
        {
            SaveProdPlan(false);
            weiterButtonDispo.SelectedIndex = 5;
        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            rollback();
            Close();
        }
    }

   



}
