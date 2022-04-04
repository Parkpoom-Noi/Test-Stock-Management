using AdaStkMgmt.Process.ZPC;
using System;
using System.Data;
using System.Windows.Forms;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.wPC
{
    public partial class wUsrEdt : Form
    {
        wStkMain oW_StkMain;
        public int nW_UsrID;
        public wUsrEdt(int pnUsrID, wStkMain poStkMain)
        {
            try
            {
                InitializeComponent();
                this.nW_UsrID = pnUsrID;
                this.oW_StkMain = poStkMain;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void wUsrEdt_Load(object sender, EventArgs e)
        {
            DataTable oDbTbl;
            int nIndex;

            try
            {
                oDbTbl = new DataTable();
                nIndex = 0;

                oDbTbl = cCtrlAuthen.C_PRCoGetDatUser(nW_UsrID);
                if (oDbTbl.Rows.Count > 0)
                {
                    for ( nIndex = 0; nIndex < oDbTbl.Rows.Count; nIndex++)
                    {
                        otbNme.Text = oDbTbl.Rows[nIndex]["FTUsrNme"].ToString();
                        otbSurNme.Text = oDbTbl.Rows[nIndex]["FTUsrSurNme"].ToString();
                        otbUsrNme.Text = oDbTbl.Rows[nIndex]["FTUsrUsrNme"].ToString();
                        otbPwd.Text = oDbTbl.Rows[nIndex]["FTUsrPwd"].ToString();

                        if (oDbTbl.Rows[nIndex]["FNAutID"].ToString() == "1")
                        {
                            ocbAut.Text = "Admin";
                            ocbAut.Items.Add("Admin");
                            ocbAut.Items.Add("Storeman");
                            ocbAut.Items.Add("User");

                        }
                        else if (oDbTbl.Rows[nIndex]["FNAutID"].ToString() == "2")
                        {
                            ocbAut.Text = "Storeman";
                            ocbAut.Items.Add("Admin");
                            ocbAut.Items.Add("Storeman");
                            ocbAut.Items.Add("User");
                        }
                        else
                        {
                            ocbAut.Text = "User";
                            ocbAut.Items.Add("Admin");
                            ocbAut.Items.Add("Storeman");
                            ocbAut.Items.Add("User");
                        }
                    }
                }

            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmEdt_Click(object sender, EventArgs e)
        {
            int nAutID;
            try
            {
                nAutID = 0;
                if (otbNme.Text != "" && otbSurNme.Text != "" && otbUsrNme.Text != "" && otbPwd.Text != "")
                {
                    switch (ocbAut.Text)
                    {
                        case "Admin": nAutID = 1; break;
                        case "Storeman": nAutID = 2; break;
                        case "User": nAutID = 3; break;
                        default: MessageBox.Show("Please select Position!"); break;
                    }
                    if (cCtrlAuthen.C_PRCbUpdateUser(otbNme.Text, otbSurNme.Text, otbUsrNme.Text, otbPwd.Text, nAutID, nW_UsrID) == true)
                    {
                        MessageBox.Show("Edit Employee complete!", "Edit Employee not complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        oW_StkMain.W_SETxDataOgdUsr();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Edit Employee not complete!", "Edit Employee not complete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Please check again", "Please check again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmCcl_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

    }
}
