using AdaStkMgmt.Process.ZPC;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.wPC
{
    public partial class wStkMgmt : Form
    {
        wStkMain oW_StkMain;
        public int nW_StkMstID;
        public int nW_UsrID;
        public int nW_UsrAutID;
        public wStkMgmt(int pnUsrAutID, int pnStkMstID, int pnUsrID, wStkMain poStkMain)
        {
            try
            {
                InitializeComponent();
                this.nW_StkMstID = pnStkMstID;
                this.nW_UsrID = pnUsrID;
                this.nW_UsrAutID = pnUsrAutID;
                this.oW_StkMain = poStkMain;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void wStkMgmt_Load(object sender, EventArgs e)
        {
            int nIndex;

            DataTable oDbTbl;
            try
            {
                nIndex = 0;

                oDbTbl = new DataTable();
                oDbTbl = cCtrlStorePo.C_PRCoGetDatStkMasterStorePo(nW_StkMstID);
                if (oDbTbl.Rows.Count > 0)
                {
                    for ( nIndex = 0; nIndex < oDbTbl.Rows.Count; nIndex++)
                    {
                        olaPrtNmbVal.Text = oDbTbl.Rows[nIndex]["FNStkMstID"].ToString();
                        olaPrtNmeVal.Text = oDbTbl.Rows[nIndex]["FTStkMstNme"].ToString();
                        olaPrtNteVal.Text = oDbTbl.Rows[nIndex]["FTStkMstNte"].ToString();
                        olaPrtTtlVal.Text = oDbTbl.Rows[nIndex]["FCStkMstTtl"].ToString();
                        olaPrtAddVal.Text = oDbTbl.Rows[nIndex]["FTUsrNme"].ToString();
                        olaPrtDteVal.Text = oDbTbl.Rows[nIndex]["FDStkMstDteAdd"].ToString();
                        olaPrtUntVal.Text = oDbTbl.Rows[nIndex]["FTStkUntTxt"].ToString();
                    }
                }
                if (nW_UsrAutID == 3)
                {
                    ocmRev.Enabled = false;
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmRev_Click(object sender, EventArgs e)
        {
            decimal cPrtTtlVal;
            decimal cReqVol;

            DialogResult oResult;
            try
            {
                cPrtTtlVal = 0;
                cReqVol = 0;
                oResult = MessageBox.Show("Do you want to Reveive ? ", "Reveive Stock", MessageBoxButtons.YesNo);
                if (oResult == DialogResult.Yes)
                {
                    cPrtTtlVal = decimal.Parse(olaPrtTtlVal.Text, CultureInfo.InvariantCulture);
                    cReqVol = decimal.Parse(otbReqVol.Text, CultureInfo.InvariantCulture);

                    //if (cPCsp.C_PRCbUpdateTotalStorePo(nW_StkMstID, decimal.Parse(olaPrtTtlVal.Text) + decimal.Parse(otbReqVol.Text)) == true && cPCsp.C_PRCbInsertTransactionStorePo(nW_StkMstID, 1, otbReqVol.Text, otbPrtTscNte.Text, nW_UsrID) == true)
                    if (cCtrlAPI.C_PRCbUpdateStkTotal(nW_StkMstID, (cPrtTtlVal + cReqVol)) == true && cCtrlAPI.C_PRCbInsertStkTransaction(nW_StkMstID, 1, otbReqVol.Text, otbPrtTscNte.Text, nW_UsrID) == true)
                    {
                        MessageBox.Show("Reveive Stock complete!", "complete!", MessageBoxButtons.OK);
                        oW_StkMain.W_SETxDataOgdStk();
                        oW_StkMain.W_SETxDataOgdTsc();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Reveive Stock not complete!", "not complete!", MessageBoxButtons.OK);
                        oW_StkMain.W_SETxDataOgdStk();
                        oW_StkMain.W_SETxDataOgdTsc();
                        Close();
                    }

                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmTrn_Click(object sender, EventArgs e)
        {            
            decimal cPrtTtlVal;
            decimal cReqVol;

            DialogResult oResult;
            try
            {
                cPrtTtlVal = 0;
                cReqVol = 0;    

                oResult = MessageBox.Show("Do you want to Transfer ? ", "Transfer Stock", MessageBoxButtons.YesNo);
                if (oResult == DialogResult.Yes)
                {
                    cPrtTtlVal = decimal.Parse(olaPrtTtlVal.Text, CultureInfo.InvariantCulture);
                    cReqVol = decimal.Parse(otbReqVol.Text, CultureInfo.InvariantCulture);
                    if (cReqVol > cPrtTtlVal)
                    {
                        cReqVol = cPrtTtlVal;
                    }
                    //if (cPCsp.C_PRCbUpdateTotalStorePo(nW_StkMstID, decimal.Parse(olaPrtTtlVal.Text) - decimal.Parse(otbReqVol.Text)) == true && cPCsp.C_PRCbInsertTransactionStorePo(nW_StkMstID, 2, otbReqVol.Text, otbPrtTscNte.Text, nW_UsrID) == true)
                    if (cCtrlAPI.C_PRCbUpdateStkTotal(nW_StkMstID, (cPrtTtlVal - cReqVol)) == true && cCtrlAPI.C_PRCbInsertStkTransaction(nW_StkMstID, 2, otbReqVol.Text, otbPrtTscNte.Text, nW_UsrID) == true)
                    {
                        MessageBox.Show("Transfer Stock complete!", "complete!", MessageBoxButtons.OK);
                        oW_StkMain.W_SETxDataOgdStk();
                        oW_StkMain.W_SETxDataOgdTsc();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Transfer Stock not complete!", "not complete!", MessageBoxButtons.OK);
                        oW_StkMain.W_SETxDataOgdStk();
                        oW_StkMain.W_SETxDataOgdTsc();
                        Close();
                    }

                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }


        private void otbReqVol_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }

        }
    }
}
