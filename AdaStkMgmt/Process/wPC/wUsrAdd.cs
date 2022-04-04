using AdaStkMgmt.Process.ZPC;
using System;
using System.Windows.Forms; 
using AdaMgMtLog;
namespace AdaStkMgmt.Process.wPC
{
    public partial class wUsrAdd : Form
    {

        wStkMain oW_StkMain;
        public wUsrAdd(wStkMain poStkMain)
        {
            try
            {
                InitializeComponent();
                this.oW_StkMain = poStkMain;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void wUsrAdd_Load(object sender, EventArgs e)
        {

            try
            {
                ocbAut.Items.Add("Admin");
                ocbAut.Items.Add("Storeman");
                ocbAut.Items.Add("User");
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
            }
        }

        private void ocmAdd_Click(object sender, EventArgs e)
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
                    if (cCtrlAuthen.C_PRCbInsertUser(otbNme.Text, otbSurNme.Text, otbUsrNme.Text, otbPwd.Text, nAutID) == true)
                    {
                        MessageBox.Show("Add Employee complete!", "Add Employee not complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        oW_StkMain.W_SETxDataOgdUsr();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Add Employee not complete!", "Add Employee not complete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
