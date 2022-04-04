using AdaStkMgmt.Process.ZPC;
using System;
using System.Globalization;
using System.Windows.Forms;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.wPC
{
    public partial class wStkAdd : Form
    {
        wStkMain oW_StkMain;
        public int nW_UsrID;
        public wStkAdd(int pnUsrID, wStkMain poStkMain)
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

        private void wStkAdd_Load(object sender, EventArgs e)
        {
            try
            { 

            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }

        }

        private void ocmStkPrtAdd_Click(object sender, EventArgs e)
        {
            int nUntID;
            try
            {
                nUntID = 0;
                if (this.olvAddPrt.Items != null)
                {
                    foreach (ListViewItem oLvItem in this.olvAddPrt.Items)
                    {
                        switch (oLvItem.SubItems[3].Text)
                        {
                            case "KG": nUntID = 1; break;
                            case "EA": nUntID = 2; break;
                            default:
                                MessageBox.Show("Please select Unit!"); break;
                                return;
                        }
                        if (cCtrlStorePo.C_PRCbInsertStorePo(oLvItem.SubItems[0].Text, oLvItem.SubItems[1].Text, decimal.Parse(oLvItem.SubItems[2].Text, CultureInfo.InvariantCulture), nUntID, nW_UsrID, "Ist") == true)
                        {
                            MessageBox.Show("Add Stock Part complete!", "Add Stock Part not complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            oW_StkMain.W_SETxDataOgdStk();
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Add Stock Part not complete!", "Add Stock Part not complete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Please Add data", "Please Add data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void ocmAddOlv_Click(object sender, EventArgs e)
        {
            ListViewItem oLvItem;
            try
            {
                oLvItem = new ListViewItem();
                if (otbStkPrtNme.Text != "" && otbStkPrtNte.Text != "" && otbStkTtl.Text != "" && ocbStkPrtUnt.Text != "")
                {
                    olvAddPrt.View = View.Details;
                    oLvItem = olvAddPrt.Items.Add(otbStkPrtNme.Text);
                    oLvItem.SubItems.Add(otbStkPrtNte.Text);
                    oLvItem.SubItems.Add(otbStkTtl.Text);
                    oLvItem.SubItems.Add(ocbStkPrtUnt.Text);


                    otbStkPrtNme.Text = "";
                    otbStkPrtNte.Text = "";
                    otbStkTtl.Text = "";
                    ocbStkPrtUnt.Text = "";
                }

                else
                {
                    MessageBox.Show("Please Add data", "Please Add data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }

        }
    }
}
