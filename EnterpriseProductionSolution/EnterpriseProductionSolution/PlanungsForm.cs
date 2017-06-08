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
        //Recordset


        public String cnStr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PPS-Datenbank.mdb";
        int neuPeriode;

        public Periodenplanung()
        {
            InitializeComponent();
            bearbeiten();
            periodenLabel1.Text = "Periode " + Convert.ToString(getNewPeriod());
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


    }
}
