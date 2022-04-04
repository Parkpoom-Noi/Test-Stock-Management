using AdaStkMgmt.Process.wPC;
using AdaStkMgmt.Process.ZPC;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using RabbitMQ.Client;
using System.Text; 
using RabbitMQ.Client.Events;
using System.Net.Http;
using AdaMgMtLog;

namespace AdaStkMgmt
{

    public partial class wUsrLgn : Form
    {
        IConnection oW_Connection;
        ConnectionFactory oW_SubFactory = new ConnectionFactory();
        IModel oW_Channel;
        Thread oW_ChkCon;
        public wUsrLgn()
        {
            try
            {
                InitializeComponent();
            } 
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void oUsrLgn_Load(object sender, EventArgs e)
        {
            try
            {  
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
            try
            {
                bStatusCon = true;
                while (oW_ChkCon.IsAlive)
                { 
                        ocmStCon.BackColor = System.Drawing.Color.White;
                        bStatusCon = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                        if (bStatusCon == true)
                        {
                            ocmStCon.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {

                            ocmStCon.BackColor = System.Drawing.Color.Red;
                        }


                    Thread.Sleep(200);
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmLogin_Click(object sender, EventArgs e)
        {
            int nUsrID;
            int nUsrAutID;

            string tMsg;
            string tUsrNme;

            byte[] anBody;

            DataTable oDbTbl;

            wUsrLgn oUsrLgn;
            wStkMain oStkMain;
            try
            {
                nUsrID = 0;
                nUsrAutID = 0;

                tMsg = "";
                tUsrNme = "";

                oUsrLgn = new wUsrLgn(); 
                if (otbUsrnme.Text != "" && otbPwd.Text != "")
                {
                    oDbTbl = new DataTable();
                    oDbTbl = cCtrlAuthen.C_PRCoGetDatLgn(otbUsrnme.Text, otbPwd.Text);
                    if (oDbTbl.Rows.Count > 0)
                    {
                        nUsrID = int.Parse(oDbTbl.Rows[0]["FNUsrID"].ToString());
                        tUsrNme = oDbTbl.Rows[0]["FTUsrNme"].ToString();
                        nUsrAutID = int.Parse(oDbTbl.Rows[0]["FNAutID"].ToString());


                        oW_Connection = oW_SubFactory.CreateConnection();
                        oW_Connection.CreateModel();
                        oW_Channel = oW_Connection.CreateModel();
                        using (oW_Connection)
                        using (oW_Channel)
                        {
                            oW_Channel.QueueDeclare(queue: "AdaPcLoginLog", durable: false, exclusive: false, autoDelete: false, arguments: null);
                            tMsg = "User " + tUsrNme + " is login Now -- " + DateTime.Now;
                            anBody = Encoding.UTF8.GetBytes(tMsg);
                            oW_Channel.BasicPublish(exchange: "", routingKey: "AdaPcLoginLog", basicProperties: null, body: anBody);
                        }
                        cSetLog.C_PRCbWriteLogLogin(tUsrNme);
                       oStkMain = new wStkMain(nUsrID, nUsrAutID, oUsrLgn);
                       oStkMain.Show();
                       this.Hide();
 
                    }
                    else
                    {
                        MessageBox.Show("Username or Password incorrect!", "Username or Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please insert Username and Password", "Request Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString()); 
            }
           

        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
