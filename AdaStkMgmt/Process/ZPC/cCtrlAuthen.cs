using System;
using System.Data;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    internal class cCtrlAuthen
    {

        #region Use for wUsrLgn
        public static DataTable C_PRCoGetDatLgn(string ptUsrnme1, string ptPwd2) //Select data user login
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT * \r\n" +
                                                    "FROM [dbo].[TPCMUser] " +
                                                    "WHERE [FTUsrUsrNme] = '" + ptUsrnme1 + "'  \r\n" +
                                                    "AND  [FTUsrPwd] = '" + ptPwd2 + "'");

                return oDbTbl;

            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            } 
        }
        #endregion

        #region Use for wStkMain Admin Tabpage
        public static DataTable C_PRCoGetDatUsr() //Select All user to DataGridViews on Admin TabPage
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT  \r\n" +
                                  "A1.[FNUsrID] as 'User ID' \r\n" +
                                  ", A1.[FTUsrNme] as 'Name' \r\n" +
                                  ", A1.[FTUsrSurNme] as 'Surname' \r\n" +
                                  ", A1.[FDUsrDteJoi] as 'Date Join' \r\n" +
                                  ", A2.[FTAutTxt] as 'Permission' \r\n" +
                              "FROM [dbo].[TPCMUser] A1 \r\n" +
                              "Left Join [dbo].[TPCMAutholize] A2 ON(A1.[FNAutID] = A2.[FNAutID])");

                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }

        public static DataTable C_PRCoGetDatUser(int pnUsrID1) //Select data user by ID
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT * \r\n" +
                                    "FROM  [dbo].[TPCMUser] " +
                                    "WHERE [FNUsrID] = " + pnUsrID1 + " ");
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }
        public static string C_PRCtGetDatNme(int pnUsrID1) //Select data user login
        {
            DataTable oDbTbl;
            string tStrNme;
            try
            {
                oDbTbl = new DataTable();
                tStrNme = "";
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT * \r\n" +
                                 "FROM  [dbo].[TPCMUser] " +
                                 "WHERE [FNUsrID] = " + pnUsrID1 + " ");
                tStrNme = oDbTbl.Rows[0]["FTUsrNme"].ToString() + " " + oDbTbl.Rows[0]["FTUsrSurNme"].ToString();
                return tStrNme;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                tStrNme = "";
                return tStrNme; 
            }

        }

        public static bool C_PRCbInsertUser(string ptUsrNme1, string ptUsrSurNme2, string ptUsrUsrNme3, string ptUsrPwd4, int pnAutID5)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_CHKbExecuteFromDB("INSERT INTO [dbo].[TPCMUser] \r\n" +
                                       "([FTUsrNme] \r\n" +
                                       ",[FTUsrSurNme] \r\n" +
                                       ",[FTUsrUsrNme] \r\n" +
                                       ",[FTUsrPwd] \r\n" +
                                       ",[FDUsrDteJoi] \r\n" +
                                       ",[FNAutID]) \r\n" +
                                "VALUES \r\n" +
                                       "( '" + ptUsrNme1 + "' \r\n" +
                                       ", '" + ptUsrSurNme2 + "' \r\n" +
                                       ", '" + ptUsrUsrNme3 + "' \r\n" +
                                       ", '" + ptUsrPwd4 + "' \r\n" +
                                       ", GETDATE() \r\n" +
                                       ", " + pnAutID5 + " )");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
        public static bool C_PRCbUpdateUser(string ptUsrNme1, string ptUsrSurNme2, string ptUsrUsrNme3, string ptUsrPwd4, int pnAutID5, int pnUsrID6)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_CHKbExecuteFromDB("UPDATE [dbo].[TPCMUser] \r\n" +
                                   "SET [FTUsrNme] = '" + ptUsrNme1 + "'  \r\n" +
                                      ",[FTUsrSurNme] = '" + ptUsrSurNme2 + "'  \r\n" +
                                      ",[FTUsrUsrNme] = '" + ptUsrUsrNme3 + "'  \r\n" +
                                      ",[FTUsrPwd] = '" + ptUsrPwd4 + "'  \r\n" +
                                      ",[FNAutID] = " + pnAutID5 + "  \r\n" +
                               "WHERE [FNUsrID] = " + pnUsrID6 + "");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
        public static bool C_PRCbDeleteUser(int pnUsrID1)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_CHKbExecuteFromDB("DELETE FROM [dbo].[TPCMUser] WHERE [FNUsrID] ='" + pnUsrID1 + "'");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }

        #endregion
    }
}
