using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace EnterprisePlanningSolution
{
    class DBHandler
    {
        public static void WriteData(string file)
        {
            //Objekt aus XML-File erstellenaa
            XmlSerializer serializer = new XmlSerializer(typeof(results));
            results resultingMessage = (results)serializer.Deserialize(new XmlTextReader(file));

            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;

            //Connection string.
            cnStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PPS-Datenbank.mdb";
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=

            try
            {
                cn.Open(cnStr);
            }
            catch (Exception test)
            {
                string dbFehler = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Datenbank konnte nicht geöffnet werden!" : "Database could not be loaded";
                MessageBox.Show(dbFehler + " " + test);
            }

            //Überprüfung ob Periode drin
            try
            {
                rs.Open("Select * From warehousestock_article WHERE period = '" + resultingMessage.period + "'", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                if (!rs.EOF)
                {
                    string periodeFehler = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Diese Periode wurde bereits importiert!" : "You can not import a period twice.";
                    MessageBox.Show(periodeFehler);
                    return;
                }
            }
            catch (Exception)
            {

            }
            finally
            {

                rs.Close();
            }

            //Tabelle warehousestock_article
            try
            {
                rs.Open("Select * From warehousestock_article", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsWarehousestockArticle myElement in resultingMessage.warehousestock.article)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["amount"].Value = myElement.amount;
                    rs.Fields["startamount"].Value = myElement.startamount;
                    rs.Fields["pct"].Value = myElement.pct;
                    rs.Fields["price"].Value = myElement.price;
                    rs.Fields["stockvalue"].Value = myElement.stockvalue;

                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {

                rs.Close();
            }

            //Tabelle warehousestock_totalvalue
            try
            {
                rs.Open("Select * From warehousestock_totalvalue", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;
                rs.Fields["stockvalue"].Value = resultingMessage.warehousestock.totalstockvalue;
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle inwardstockmovement
            try
            {
                rs.Open("Select * From inwardstockmovement", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsOrder myElement in resultingMessage.inwardstockmovement)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["orderperiod"].Value = myElement.orderperiod;
                    rs.Fields["mode"].Value = myElement.mode;
                    rs.Fields["article"].Value = myElement.article;
                    rs.Fields["amount"].Value = myElement.amount;
                    rs.Fields["time"].Value = myElement.time;
                    rs.Fields["materialcosts"].Value = myElement.materialcosts;
                    rs.Fields["ordercosts"].Value = myElement.ordercosts;
                    rs.Fields["entirecosts"].Value = myElement.entirecosts;
                    rs.Fields["piececosts"].Value = myElement.piececosts;
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }

            //Tabelle futureinwardstockmovement
            try
            {
                rs.Open("Select * From futureinwardstockmovement", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsOrder1 myElement in resultingMessage.futureinwardstockmovement)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["orderperiod"].Value = myElement.orderperiod;
                    rs.Fields["mode"].Value = myElement.mode;
                    rs.Fields["article"].Value = myElement.article;
                    rs.Fields["amount"].Value = myElement.amount;
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle idletimecosts_workplace
            try
            {
                rs.Open("Select * From idletimecosts_workplace", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsIdletimecostsWorkplace myElement in resultingMessage.idletimecosts.workplace)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["setupevents"].Value = myElement.setupevents;
                    rs.Fields["idletime"].Value = myElement.idletime;
                    rs.Fields["wageidletimecosts"].Value = myElement.wageidletimecosts;
                    rs.Fields["wagecosts"].Value = myElement.wagecosts;
                    rs.Fields["machineidletimecosts"].Value = myElement.machineidletimecosts;
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }


            //Tabelle idletimecosts_sum
            try
            {
                rs.Open("Select * From idletimecosts_sum", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;
                rs.Fields["setupevents"].Value = resultingMessage.idletimecosts.sum.setupevents;
                rs.Fields["idletime"].Value = resultingMessage.idletimecosts.sum.idletime;
                rs.Fields["wageidletimecosts"].Value = resultingMessage.idletimecosts.sum.wageidletimecosts;
                rs.Fields["wagecosts"].Value = resultingMessage.idletimecosts.sum.wagecosts;
                rs.Fields["machineidletimecosts"].Value = resultingMessage.idletimecosts.sum.machineidletimecosts;
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }


            //Tabelle waitinglistworkstations
            try
            {
                rs.Open("Select * From waitinglistworkstations", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsWorkplace myElement in resultingMessage.waitinglistworkstations)
                {
                    if (myElement.waitinglist == null)
                    {
                        rs.AddNew();
                        rs.Fields["period"].Value = resultingMessage.period;
                        rs.Fields["id"].Value = myElement.id;
                        rs.Fields["timeneed_sum"].Value = myElement.timeneed;
                    }
                    else
                    {
                        foreach (resultsWorkplaceWaitinglist myUnterelement in myElement.waitinglist)
                        {
                            rs.AddNew();
                            rs.Fields["period"].Value = resultingMessage.period;
                            rs.Fields["id"].Value = myElement.id;
                            rs.Fields["timeneed_sum"].Value = myElement.timeneed;

                            rs.Fields["period_wp"].Value = myUnterelement.period;
                            rs.Fields["order"].Value = myUnterelement.order;
                            rs.Fields["firstbatch"].Value = myUnterelement.firstbatch;
                            rs.Fields["lastbatch"].Value = myUnterelement.lastbatch;
                            rs.Fields["item"].Value = myUnterelement.item;
                            rs.Fields["amount"].Value = myUnterelement.amount;
                            rs.Fields["timeneed"].Value = myUnterelement.timeneed;
                        }
                    }
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }


            //TODO WaitinglistStock
            try
            {
                rs.Open("Select * From waitingliststock", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsMissingpart missingpart in resultingMessage.waitingliststock)
                {
                    foreach (resultsMissingpartWaitinglist myWaitingListElement in missingpart.waitinglist)
                    {
                        rs.AddNew();
                        rs.Fields["missingpart"].Value = missingpart.id;
                        rs.Fields["period"].Value = resultingMessage.period;
                        rs.Fields["item"].Value = myWaitingListElement.item;
                        rs.Fields["amount"].Value = myWaitingListElement.amount;
                        rs.Fields["order"].Value = myWaitingListElement.order;
                        rs.Fields["firstbatch"].Value = myWaitingListElement.firstbatch;
                        rs.Fields["lastbatch"].Value = myWaitingListElement.lastbatch;
                    }
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }

            //TODO orders inwrok mit liste?
            //Tabelle ordersinwork
            try
            {
                rs.Open("Select * From ordersinwork", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsWorkplace1 myElement in resultingMessage.ordersinwork)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["period_oiw"].Value = myElement.period;
                    rs.Fields["order"].Value = myElement.order;
                    rs.Fields["batch"].Value = myElement.batch;
                    rs.Fields["item"].Value = myElement.item;
                    rs.Fields["amount"].Value = myElement.amount;
                    rs.Fields["timeneed"].Value = myElement.timeneed;
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle completedorders
            try
            {
                rs.Open("Select * From completedorders", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsOrder2 myElement in resultingMessage.completedorders)
                {
                    foreach (resultsOrderBatch myUnterelement in myElement.batch)
                    {
                        rs.AddNew();
                        rs.Fields["period"].Value = resultingMessage.period;
                        rs.Fields["o_period"].Value = myElement.period;
                        rs.Fields["o_id"].Value = myElement.id;
                        rs.Fields["o_item"].Value = myElement.item;
                        rs.Fields["o_quantity"].Value = myElement.quantity;
                        rs.Fields["o_cost"].Value = myElement.cost;
                        rs.Fields["o_averageunitcosts"].Value = myElement.averageunitcosts;

                        rs.Fields["b_id"].Value = myUnterelement.id;
                        rs.Fields["b_amount"].Value = myUnterelement.amount;
                        rs.Fields["b_cycletime"].Value = myUnterelement.cycletime;
                        rs.Fields["b_cost"].Value = myUnterelement.cost;
                    }
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }


            //Tabelle cycletimes
            try
            {
                rs.Open("Select * From cycletimes", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;
                rs.Fields["startedorders"].Value = resultingMessage.cycletimes.startedorders;
                rs.Fields["waitingorders"].Value = resultingMessage.cycletimes.waitingorders;
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }


            //Tabelle cycletimes_order
            try
            {
                rs.Open("Select * From cycletimes_order", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                foreach (resultsCycletimesOrder myElement in resultingMessage.cycletimes.order)
                {
                    rs.AddNew();
                    rs.Fields["period"].Value = resultingMessage.period;
                    rs.Fields["id"].Value = myElement.id;
                    rs.Fields["period_order"].Value = myElement.period;
                    rs.Fields["starttime"].Value = myElement.starttime;
                    rs.Fields["finishtime"].Value = myElement.finishtime;
                    rs.Fields["cycletimemin"].Value = myElement.cycletimemin;
                    rs.Fields["cycletimefactor"].Value = myElement.cycletimefactor;
                }
                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }

            //Tabelle general
            try
            {
                rs.Open("Select * From tbl_general", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;

                rs.Fields["capacity_current"].Value = resultingMessage.result.general.capacity.current;
                rs.Fields["capacity_average"].Value = resultingMessage.result.general.capacity.average;
                rs.Fields["capacity_all"].Value = resultingMessage.result.general.capacity.all;

                rs.Fields["possiblecapacity_current"].Value = resultingMessage.result.general.possiblecapacity.current;
                rs.Fields["possiblecapacity_average"].Value = resultingMessage.result.general.possiblecapacity.average;
                rs.Fields["possiblecapacity_all"].Value = resultingMessage.result.general.possiblecapacity.all;

                rs.Fields["relpossiblenormalcapacity_current"].Value = resultingMessage.result.general.relpossiblenormalcapacity.current;
                rs.Fields["relpossiblenormalcapacity_average"].Value = resultingMessage.result.general.relpossiblenormalcapacity.average;
                rs.Fields["relpossiblenormalcapacity_all"].Value = resultingMessage.result.general.relpossiblenormalcapacity.all;

                rs.Fields["productivetime_current"].Value = resultingMessage.result.general.productivetime.current;
                rs.Fields["productivetime_average"].Value = resultingMessage.result.general.productivetime.average;
                rs.Fields["productivetime_all"].Value = resultingMessage.result.general.productivetime.all;

                rs.Fields["effiency_current"].Value = resultingMessage.result.general.effiency.current;
                rs.Fields["effiency_average"].Value = resultingMessage.result.general.effiency.average;
                rs.Fields["effiency_all"].Value = resultingMessage.result.general.effiency.all;

                rs.Fields["sellwish_current"].Value = resultingMessage.result.general.sellwish.current;
                rs.Fields["sellwish_average"].Value = resultingMessage.result.general.sellwish.average;
                rs.Fields["sellwish_all"].Value = resultingMessage.result.general.sellwish.all;

                rs.Fields["salesquantity_current"].Value = resultingMessage.result.general.salesquantity.current;
                rs.Fields["salesquantity_average"].Value = resultingMessage.result.general.salesquantity.average;
                rs.Fields["salesquantity_all"].Value = resultingMessage.result.general.salesquantity.all;

                rs.Fields["deliveryreliability_current"].Value = resultingMessage.result.general.deliveryreliability.current;
                rs.Fields["deliveryreliability_average"].Value = resultingMessage.result.general.deliveryreliability.average;
                rs.Fields["deliveryreliability_all"].Value = resultingMessage.result.general.deliveryreliability.all;

                rs.Fields["idletime_current"].Value = resultingMessage.result.general.idletime.current;
                rs.Fields["idletime_average"].Value = resultingMessage.result.general.idletime.average;
                rs.Fields["idletime_all"].Value = resultingMessage.result.general.idletime.all;

                rs.Fields["idletimecosts_current"].Value = resultingMessage.result.general.idletimecosts.current;
                rs.Fields["idletimecosts_average"].Value = resultingMessage.result.general.idletimecosts.average;
                rs.Fields["idletimecosts_all"].Value = resultingMessage.result.general.idletimecosts.all;

                rs.Fields["storevalue_current"].Value = resultingMessage.result.general.storevalue.current;
                rs.Fields["storevalue_average"].Value = resultingMessage.result.general.storevalue.average;
                rs.Fields["storevalue_all"].Value = resultingMessage.result.general.storevalue.all;

                rs.Fields["storagecosts_current"].Value = resultingMessage.result.general.storagecosts.current;
                rs.Fields["storagecosts_average"].Value = resultingMessage.result.general.storagecosts.average;
                rs.Fields["storagecosts_all"].Value = resultingMessage.result.general.storagecosts.all;

                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle normalsale
            try
            {
                rs.Open("Select * From normalsale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;

                rs.Fields["salesprice_current"].Value = resultingMessage.result.normalsale.salesprice.current;
                rs.Fields["salesprice_average"].Value = resultingMessage.result.normalsale.salesprice.average;
                rs.Fields["salesprice_all"].Value = resultingMessage.result.normalsale.salesprice.all;

                rs.Fields["profit_current"].Value = resultingMessage.result.normalsale.profit.current;
                rs.Fields["profit_average"].Value = resultingMessage.result.normalsale.profit.average;
                rs.Fields["profit_all"].Value = resultingMessage.result.normalsale.profit.all;

                rs.Fields["profitperunit_current"].Value = resultingMessage.result.normalsale.profitperunit.current;
                rs.Fields["profitperunit_average"].Value = resultingMessage.result.normalsale.profitperunit.average;
                rs.Fields["profitperunit_all"].Value = resultingMessage.result.normalsale.profitperunit.all;

                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle directsale
            try
            {
                rs.Open("Select * From directsale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;

                rs.Fields["profit_current"].Value = resultingMessage.result.directsale.profit.current;
                rs.Fields["profit_average"].Value = resultingMessage.result.directsale.profit.average;
                rs.Fields["profit_all"].Value = resultingMessage.result.directsale.profit.all;

                rs.Fields["contractpenalty_current"].Value = resultingMessage.result.directsale.contractpenalty.current;
                rs.Fields["contractpenalty_average"].Value = resultingMessage.result.directsale.contractpenalty.average;
                rs.Fields["contractpenalty_all"].Value = resultingMessage.result.directsale.contractpenalty.all;

                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle marketplacesale
            try
            {
                rs.Open("Select * From marketplacesale", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;

                rs.Fields["profit_current"].Value = resultingMessage.result.marketplacesale.profit.current;
                rs.Fields["profit_average"].Value = resultingMessage.result.marketplacesale.profit.average;
                rs.Fields["profit_all"].Value = resultingMessage.result.marketplacesale.profit.all;

                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }



            //Tabelle summary
            try
            {
                rs.Open("Select * From summary", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                rs.AddNew();
                rs.Fields["period"].Value = resultingMessage.period;

                rs.Fields["profit_current"].Value = resultingMessage.result.summary.profit.current;
                rs.Fields["profit_average"].Value = resultingMessage.result.summary.profit.average;
                rs.Fields["profit_all"].Value = resultingMessage.result.summary.profit.all;

                rs.Update();
            }
            catch (Exception)
            {

            }
            finally
            {
                rs.Close();
            }

            MessageBox.Show("Alles Importiert");

            cn.Close();

        }
    }
}
