using AdaStkMgmt.Process.ZPC;
using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic; 
using System.Threading;
using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.wPC
{
    public partial class wStkMain : Form
    {
        wUsrLgn oW_UsrLgn;
        public int nW_UsrID;
        public int nW_UsrAutID;
        IConnection oW_Connection;
        ConnectionFactory oW_SubFactory = new ConnectionFactory();
        IModel oW_Channel;
        Thread oW_ChkCon;
        public wStkMain(int pnUsrID, int pnUsrAutID, wUsrLgn poUsrLgn)
        {

            try
            {
                InitializeComponent();
                nW_UsrID = pnUsrID;
                nW_UsrAutID = pnUsrAutID;
                oW_UsrLgn = poUsrLgn;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }


        private void oStkMain_Load(object sender, EventArgs e)
        {
            try
            {

                olaNme.Text = cCtrlAuthen.C_PRCtGetDatNme(nW_UsrID);
                if (nW_UsrAutID == 1) // Admin
                {

                    W_SETxDataOgdUsr();
                    W_SETxDataOgdStk();
                    W_SETxDataOgdTsc();
                    W_SETxDataOgdLgnLog();

                }
                else if (nW_UsrAutID == 2)//Store
                {
                    otaCtrl.TabPages.Remove(otaAdm);
                    otaCtrl.TabPages.Remove(otaLgnLog);
                    W_SETxDataOgdStk();
                    W_SETxDataOgdTsc();
                }
                else
                {
                    otaCtrl.TabPages.Remove(otaAdm);
                    otaCtrl.TabPages.Remove(otaTsc);
                    otaCtrl.TabPages.Remove(otaLgnLog);
                    ocmAddStk.Enabled = false;
                    W_SETxDataOgdStk();
                }

                oW_ChkCon = new Thread(new ThreadStart(W_PRCxSttCon));
                oW_ChkCon.IsBackground = true;
                oW_ChkCon.Start();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }

        }
        public void W_PRCxSttCon()
        {
            bool bStatusCon;
            string tLog;
            byte[] anBody;
            string tMsg;
            try
            {
                bStatusCon = true;
                tLog = "";
                tMsg = "";
                while (oW_ChkCon.IsAlive)
                {
                    ocmStCon.BackColor = System.Drawing.Color.White;
                    Thread.Sleep(500);
                    bStatusCon = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                    if (bStatusCon == true)
                    {
                        ocmStCon.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        ocmStCon.BackColor = System.Drawing.Color.Red;
                    }
                    oW_Connection = oW_SubFactory.CreateConnection();
                    oW_Connection.CreateModel();
                    oW_Channel = oW_Connection.CreateModel();
                    using (oW_Connection)
                    using (oW_Channel)
                    {
                        oW_Channel.QueueDeclare(queue: "AdaPcLoginLog", durable: false, exclusive: false, autoDelete: false, arguments: null);
                        EventingBasicConsumer oW_Consumer = new EventingBasicConsumer(oW_Channel);
                        oW_Channel.BasicConsume("AdaPcLoginLog", true, oW_Consumer);
                        oW_Consumer.Received += (model, aoData) =>
                        {
                            anBody = aoData.Body.ToArray();
                            tMsg = Encoding.UTF8.GetString(anBody);
                            tLog = tMsg;
                            //MessageBox.Show(tMsg);
                            if (tLog != "")
                            {
                                cCtrlMQ.C_PRCbInsertMqLog(tLog);
                            }
                        };
                        oW_Channel.BasicConsume("AdaPcLoginLog", true, oW_Consumer);
                    }

                    Thread.Sleep(200);
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            } 
        }

        private void oStkMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        #region Admin user management tabpage
        public void W_SETxDataOgdUsr()
        {
            DataGridViewButtonColumn ocmUsrEdt;
            DataGridViewButtonColumn ocmUsrDlt;

            try
            {
                ocmUsrEdt = new DataGridViewButtonColumn();
                ocmUsrDlt = new DataGridViewButtonColumn();

                ogdUsr.Columns.Clear();
                ogdUsr.DataSource = cCtrlAuthen.C_PRCoGetDatUsr();

                ocmUsrEdt.HeaderText = "Edit";
                ocmUsrEdt.Text = "Edit";
                ocmUsrEdt.Name = "ocmUsrEdt";
                ocmUsrEdt.UseColumnTextForButtonValue = true;
                ogdUsr.Columns.Insert(0, ocmUsrEdt);

                ocmUsrDlt.HeaderText = "Delete";
                ocmUsrDlt.Text = "Delete";
                ocmUsrDlt.Name = "ocmUsrDlt";
                ocmUsrDlt.UseColumnTextForButtonValue = true;
                ogdUsr.Columns.Insert(1, ocmUsrDlt);

                ogdUsr.Refresh();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }
        private void ogdUsr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nUsrID;
            wUsrEdt oUsrEdt;
            string tMsg;
            DialogResult oResult;
            try
            {
                nUsrID = 0;
                tMsg = "";
                oResult = new DialogResult();
                if (e.ColumnIndex == 0) // Edit
                {
                    nUsrID = int.Parse(ogdUsr.Rows[e.RowIndex].Cells[2].Value.ToString());
                    oUsrEdt = new wUsrEdt(nUsrID, this);
                    oUsrEdt.Show();

                }
                else if (e.ColumnIndex == 1) // Delete
                {
                    nUsrID = 0;
                    nUsrID = int.Parse(ogdUsr.Rows[e.RowIndex].Cells[2].Value.ToString());
                    tMsg = "Do you want to delete : " + ogdUsr.Rows[e.RowIndex].Cells[3].Value + " " + ogdUsr.Rows[e.RowIndex].Cells[4].Value + " ? ";
                    oResult = MessageBox.Show(tMsg, "Delete User", MessageBoxButtons.YesNo);
                    if (oResult == DialogResult.Yes)
                    {
                        if (cCtrlAuthen.C_PRCbDeleteUser(nUsrID) == true)
                        {
                            MessageBox.Show("Delete record complete!", "complete!", MessageBoxButtons.OK);
                            W_SETxDataOgdUsr();
                        }
                        else
                        {
                            MessageBox.Show("Delete record not complete!", "not complete!", MessageBoxButtons.OK);
                            W_SETxDataOgdUsr();
                        }

                    }

                }

            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmAddUsr_Click(object sender, EventArgs e)
        {
            wUsrAdd oUsrAdd;
            try
            {
                oUsrAdd = new wUsrAdd(this);
                oUsrAdd.ShowDialog();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        #endregion

        #region Stock Management tabpage
        private void ocmAddStk_Click(object sender, EventArgs e)
        {
            wStkAdd oStkAdd;
            try
            {
                oStkAdd = new wStkAdd(nW_UsrID, this);
                oStkAdd.ShowDialog();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }
        public void W_SETxDataOgdStk()
        {
            DataGridViewButtonColumn ocmStkTsc;
            DataGridViewButtonColumn ocmStkEdt;
            DataGridViewButtonColumn ocmStkDlt;
            try
            {

                ocmStkEdt = new DataGridViewButtonColumn();
                ocmStkDlt = new DataGridViewButtonColumn();
                ocmStkTsc = new DataGridViewButtonColumn();

                ogdStk.Columns.Clear();
                ogdStk.DataSource = cCtrlStorePo.C_PRCoGetDatStkMaster();

                if (nW_UsrAutID == 3) // user
                {
                    ocmStkTsc.HeaderText = "Receive/Transfer";
                    ocmStkTsc.Text = "Receive/Transfer";
                    ocmStkTsc.Name = "ocmStkTsc";
                    ocmStkTsc.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(0, ocmStkTsc);
                }
                else
                {
                    ocmStkEdt.HeaderText = "Edit";
                    ocmStkEdt.Text = "Edit";
                    ocmStkEdt.Name = "ocmStkEdt";
                    ocmStkEdt.UseColumnTextForButtonValue = true;
                    ocmStkEdt.ReadOnly = true;
                    ogdStk.Columns.Insert(0, ocmStkEdt);

                    ocmStkDlt.HeaderText = "Delete";
                    ocmStkDlt.Text = "Delete";
                    ocmStkDlt.Name = "ocmStkDlt";
                    ocmStkDlt.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(1, ocmStkDlt);

                    ocmStkTsc.HeaderText = "Receive/Transfer";
                    ocmStkTsc.Text = "Receive/Transfer";
                    ocmStkTsc.Name = "ocmStkTsc";
                    ocmStkTsc.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(2, ocmStkTsc);
                }

                ogdStk.Refresh();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }
        private void otbScrh_TextChanged(object sender, EventArgs e)
        {

            DataGridViewButtonColumn ocmStkTsc;
            DataGridViewButtonColumn ocmStkEdt;
            DataGridViewButtonColumn ocmStkDlt;
            try
            {
                ocmStkEdt = new DataGridViewButtonColumn();
                ocmStkDlt = new DataGridViewButtonColumn();
                ocmStkTsc = new DataGridViewButtonColumn();

                ogdStk.Columns.Clear();
                ogdStk.DataSource = cCtrlStorePo.C_PRCoGetDatStkSearch(otbScrh.Text);
                if (nW_UsrAutID == 3) // user
                {
                    ocmStkTsc.HeaderText = "Receive/Transfer";
                    ocmStkTsc.Text = "Receive/Transfer";
                    ocmStkTsc.Name = "ocmStkTsc";
                    ocmStkTsc.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(0, ocmStkTsc);
                }
                else
                {
                    ocmStkEdt.HeaderText = "Edit";
                    ocmStkEdt.Text = "Edit";
                    ocmStkEdt.Name = "ocmStkEdt";
                    ocmStkEdt.UseColumnTextForButtonValue = true;
                    ocmStkEdt.ReadOnly = true;
                    ogdStk.Columns.Insert(0, ocmStkEdt);

                    ocmStkDlt.HeaderText = "Delete";
                    ocmStkDlt.Text = "Delete";
                    ocmStkDlt.Name = "ocmStkDlt";
                    ocmStkDlt.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(1, ocmStkDlt);

                    ocmStkTsc.HeaderText = "Receive/Transfer";
                    ocmStkTsc.Text = "Receive/Transfer";
                    ocmStkTsc.Name = "ocmStkTsc";
                    ocmStkTsc.UseColumnTextForButtonValue = true;
                    ogdStk.Columns.Insert(2, ocmStkTsc);
                }

                ogdStk.Refresh();

            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }


        private void ogdStk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nColEdt;
            int nColDlt;
            int nColTsc;
            int nStkMstID;

            string tHdeCol;
            string tMsg;

            wStkMgmt oStkMgmt;
            wStkEdt oStkEdt;

            DialogResult oResult;
            try
            {
                nColEdt = 0;
                nColDlt = 0;
                nColTsc = 0;
                nStkMstID = 0; 

                tHdeCol = "";
                tMsg = "";

                if (nW_UsrAutID == 3) // user
                {
                    if (e.ColumnIndex == 0) // Transfer
                    {
                        nStkMstID = int.Parse(ogdStk.Rows[e.RowIndex].Cells[2].Value.ToString());
                        oStkMgmt = new wStkMgmt(nW_UsrAutID, nStkMstID, nW_UsrID, this);
                        oStkMgmt.Show();

                    }
                }
                else
                {

                    if (e.ColumnIndex == 0) // Edit
                    {
                        nStkMstID = int.Parse(ogdStk.Rows[e.RowIndex].Cells[4].Value.ToString());
                        oStkEdt = new wStkEdt(nStkMstID, this);
                        oStkEdt.Show();

                    }
                    else if (e.ColumnIndex == 1) // Delete
                    {
                        nStkMstID = int.Parse(ogdStk.Rows[e.RowIndex].Cells[4].Value.ToString());
                        tMsg = "Do you want to delete : " + ogdStk.Rows[e.RowIndex].Cells[5].Value + " " + ogdStk.Rows[e.RowIndex].Cells[6].Value + " ? ";
                        oResult = MessageBox.Show(tMsg, "Delete Stock part", MessageBoxButtons.YesNo);
                        if (oResult == DialogResult.Yes)
                        {
                            if (cCtrlStorePo.C_PRCbDeleteStorePo(nStkMstID) == true)
                            {
                                MessageBox.Show("Delete record complete!", "complete!", MessageBoxButtons.OK);
                                W_SETxDataOgdStk();
                            }
                            else
                            {
                                MessageBox.Show("Delete record not complete!", "not complete!", MessageBoxButtons.OK);
                                W_SETxDataOgdStk();
                            }

                        }

                    }
                    else if (e.ColumnIndex == 2) // Transfer
                    {
                        nStkMstID = int.Parse(ogdStk.Rows[e.RowIndex].Cells[4].Value.ToString());
                        oStkMgmt = new wStkMgmt(nW_UsrAutID, nStkMstID, nW_UsrID, this);
                        oStkMgmt.Show();

                    }
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }

        }
        #endregion
        public void W_SETxDataOgdTsc()
        {
            HttpClient oClint;
            HttpResponseMessage oRespns;
            object oDatStkScrh;
            try
            {
                oClint = new HttpClient();
                oClint.BaseAddress = new Uri("http://localhost:54554/");
                oRespns = oClint.GetAsync("AdaPcApi/GetStockTransaction").Result;
                oDatStkScrh = oRespns.Content.ReadAsAsync<IEnumerable<cmlCallAPI.cmlResStockTransactionSelect>>().Result;

                ogdTsc.DataSource = oDatStkScrh;
                if (nW_UsrAutID != 3) // user
                {
                    ogdTsc.Columns["rnNo_"].HeaderText = "No.";
                    ogdTsc.Columns["rnTransaction_ID"].HeaderText = "Transaction ID";
                    ogdTsc.Columns["rnPart_Number"].HeaderText = "Part Number";
                    ogdTsc.Columns["rtPart_name"].HeaderText = "Part name";
                    ogdTsc.Columns["rtTransaction_type"].HeaderText = "Transaction type";
                    ogdTsc.Columns["rtTransaction_volume"].HeaderText = "Transaction volume";
                    ogdTsc.Columns["rtTransaction_note"].HeaderText = "Transaction note";
                    ogdTsc.Columns["rdTransaction_Date"].HeaderText = "Transaction Date";
                    ogdTsc.Columns["rtTransaction_by"].HeaderText = "Transaction by";
                }
                //ogdTsc.Columns.Clear();
                //ogdTsc.DataSource = cPCsp.C_PRCoGetDatStkTransaction();
                //ogdTsc.Refresh();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString()); 
            }
        }

        public void W_SETxDataOgdLgnLog()
        {

            try
            {
                ogdLgnLog.Columns.Clear();
                ogdLgnLog.DataSource = cCtrlMQ.C_PRCoGetDatMqLog();
                ogdLgnLog.Refresh();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmRefsh_Click(object sender, EventArgs e)
        {
            try
            {
                W_SETxDataOgdLgnLog();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }
         
    }
}

