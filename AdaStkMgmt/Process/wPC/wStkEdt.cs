using AdaStkMgmt.Process.ZPC;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.wPC
{
    public partial class wStkEdt : Form
    {
        wStkMain oW_StkMain;
        public int nW_StkMstID;
        public wStkEdt(int pnStkMstID, wStkMain poStkMain)
        {
            try
            {
                InitializeComponent();
                this.nW_StkMstID = pnStkMstID;
                this.oW_StkMain = poStkMain;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void wStkEdt_Load(object sender, EventArgs e)
        {
            DataTable oDbTbl;
            int nIndex;
            try
            {
                oDbTbl = new DataTable();
                nIndex = 0;
                oDbTbl = cCtrlStorePo.C_PRCoGetDatStkMasterStorePo(nW_StkMstID);
                if (oDbTbl.Rows.Count > 0)
                {
                    for (nIndex = 0; nIndex < oDbTbl.Rows.Count; nIndex++)
                    {
                        otbStkPrtNme.Text = oDbTbl.Rows[nIndex]["FTStkMstNme"].ToString();
                        otbStkPrtNte.Text = oDbTbl.Rows[nIndex]["FTStkMstNte"].ToString();
                        otbStkTtl.Text = oDbTbl.Rows[nIndex]["FCStkMstTtl"].ToString();

                        if (oDbTbl.Rows[nIndex]["FNStkUntID"].ToString() == "1")
                        {
                            ocbStkPrtUnt.Text = "KG";
                            ocbStkPrtUnt.Items.Add("KG");
                            ocbStkPrtUnt.Items.Add("EA");

                        }
                        else
                        {
                            ocbStkPrtUnt.Text = "EA";
                            ocbStkPrtUnt.Items.Add("KG");
                            ocbStkPrtUnt.Items.Add("EA");
                        }
                    }
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmStkPrtEdt_Click(object sender, EventArgs e)
        {
            int nUntID;
            try
            {
                nUntID = 0;
                if (otbStkPrtNme.Text != "" && otbStkPrtNte.Text != "" && otbStkTtl.Text != "")
                {
                    switch (ocbStkPrtUnt.Text)
                    {
                        case "KG": nUntID = 1; break;
                        case "EA": nUntID = 2; break;
                        default: MessageBox.Show("Please select Unit!"); break;
                    }
                    if (cCtrlStorePo.C_PRCbUpdateStorePo(nW_StkMstID, otbStkPrtNme.Text, otbStkPrtNte.Text, decimal.Parse(otbStkTtl.Text, CultureInfo.InvariantCulture), nUntID) == true)
                    {
                        MessageBox.Show("Edit Stock Part complete!", "Edit Stock Part not complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        oW_StkMain.W_SETxDataOgdStk();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Edit Stock Part not complete!", "Edit Stock Part not complete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ocmStkPrtCcl_Click(object sender, EventArgs e)
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
