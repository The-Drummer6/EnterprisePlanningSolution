using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int neuPeriode;

        public Periodenplanung()
        {
             InitializeComponent();
            bearbeiten();
            metroTabControl1.SelectedIndex = 0;
            periodenLabel1.Text = Convert.ToString(getNewPeriod());
            periodenLabel2.Text = periodenLabel1.Text;
            tBPeriode.Text = periodenLabel1.Text;
            addNewPeriod();
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

        private void addNewPeriod()
        {


            int neuPeriode = getNewPeriod();

            int cB = neuPeriode;
            int cB1 = neuPeriode + 1;
            int cB2 = neuPeriode + 2;
            int cB3 = neuPeriode + 3;

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
            cn.Open(cnStr);
          
          

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
           
            cn.Close();
            
        }

        private void weiterButton1_Click(object sender, EventArgs e)
        {
            if (tBPP1N0.Text == "" || tBPP1N1.Text == "" || tBPP1N2.Text == "" || tBPP1N3.Text == "" || tBPP2N0.Text == "" || tBPP2N1.Text == "" || tBPP2N2.Text == "" || tBPP2N3.Text == "" || tBPP3N0.Text == "" || tBPP3N1.Text == "" || tBPP3N2.Text == "" || tBPP3N3.Text == "" || tBGP1N0.Text == "" || tBGP1N1.Text == "" || tBGP1N2.Text == "" || tBGP1N3.Text == "" || tBGP2N0.Text == "" || tBGP2N1.Text == "" || tBGP2N2.Text == "" || tBGP2N3.Text == "" || tBGP3N0.Text == "" || tBGP3N1.Text == "" || tBGP3N2.Text == "" || tBGP3N3.Text == "")
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Felder dürfen nicht leer sein!" : "Fields must not be empty!";
                MessageBox.Show(LadeError);

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

                rsSW0.Open("Select * From sellwish where period =" + cB+ "and planPeriod =" + cB + " order by article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
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

        metroTabControl1.SelectedIndex = 1;

        }

        private void mweiterButton2_Click(object sender, EventArgs e)
        {
            if (tBP1.Text == "" || tBP1P.Text == "" || tBP1S.Text == "" || tBP2.Text == "" || tBP2P.Text == "" || tBP2S.Text == "" || tBP3.Text == "" || tBP3P.Text == "" || tBP3S.Text == "")
            {
                string LadeError = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Felder dürfen nicht leer sein!" : "Fields must not be empty!";
                MessageBox.Show(LadeError);

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
        
        metroTabControl1.SelectedIndex = 2;
        }
    }
}
