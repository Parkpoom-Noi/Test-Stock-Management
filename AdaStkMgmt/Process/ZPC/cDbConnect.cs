using System;
using System.Data;
using System.Data.SqlClient;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    public class cDbConnect
    {
        #region SQL Command
        public static DataTable C_GEToSelectFromDB(string ptSqlTxt1)//Function Select data from Database return Datatable
        {
            string tDbPath;

            DataTable oDbTbl;
            SqlConnection oDbCon;
            SqlCommand oDbCmd;
            SqlDataAdapter oDbAdt;

            try
            {
                oDbTbl = new DataTable();
                tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                oDbCmd = oDbCon.CreateCommand();
                oDbCmd.CommandText = ptSqlTxt1;
                oDbAdt = new SqlDataAdapter(oDbCmd);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }
        }


        public static bool C_CHKbExecuteFromDB(string ptSqlTxt1) //Function Excute data to Database return boolean
        {
            bool bResult;

            try
            {
                bResult = true;
                string tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                SqlConnection oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                SqlCommand oDbCmd = oDbCon.CreateCommand();
                oDbCmd.CommandText = ptSqlTxt1;
                bResult = Convert.ToBoolean(oDbCmd.ExecuteNonQuery());
                oDbCon.Close();
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }


        #endregion


        #region By Store Procedure
        public static DataTable C_GEToSelectStorePo(int pnStkMstID1)
        {
            string tDbPath;

            DataTable oDbTbl;
            SqlConnection oDbCon;
            SqlCommand oDbCmd;
            SqlDataAdapter oDbAdt;

            try
            {
                oDbTbl = new DataTable();
                tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                oDbCmd = new SqlCommand("STP_PRCbGetStockByID", oDbCon);
                oDbCmd.CommandType = CommandType.StoredProcedure;

                oDbCmd.Parameters.Add("@pnStkMstID", SqlDbType.NVarChar).Value = pnStkMstID1;

                oDbAdt = new SqlDataAdapter(oDbCmd);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                oDbTbl = null;

            }
            return oDbTbl;
        }


        public static bool C_PRCbExcuteStorePo(int pnStkMstID1, string ptStkMstNme2, string ptStkMstNte3, decimal pcStkMstTtl4
                                        , int pnStkUntID5, int pnUsrID6, string ptStmTyp7) //Function Excute data to Database return boolean
        {
            bool bResult; 
            string tDbPath;
             
            SqlConnection oDbCon;
            SqlCommand oDbCmd; 
            try
            {
                bResult = true;
                tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                oDbCmd = new SqlCommand("STP_PRCbStockMasterExecute", oDbCon);
                oDbCmd.CommandType = CommandType.StoredProcedure;
                oDbCmd.Parameters.Add("@pnStkMstID", SqlDbType.Int).Value = pnStkMstID1;
                oDbCmd.Parameters.Add("@ptStkMstNme", SqlDbType.NVarChar).Value = ptStkMstNme2;
                oDbCmd.Parameters.Add("@ptStkMstNte", SqlDbType.Text).Value = ptStkMstNte3;
                oDbCmd.Parameters.Add("@pcStkMstTtl", SqlDbType.Decimal).Value = pcStkMstTtl4;
                oDbCmd.Parameters.Add("@pnStkUntID", SqlDbType.Int).Value = pnStkUntID5;
                oDbCmd.Parameters.Add("@pnUsrID", SqlDbType.Int).Value = pnUsrID6;
                oDbCmd.Parameters.Add("@ptExecuteType", SqlDbType.NVarChar).Value = ptStmTyp7;

                bResult = Convert.ToBoolean(oDbCmd.ExecuteNonQuery());
                oDbCon.Close();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                bResult = false;

            }
            return bResult;
        }
         
        public static bool C_PRCbExcuteTransactionStorepo(int pnStkMstID1, decimal pcStkMstTtl2)
        {
            bool bResult;
            string tDbPath;

            SqlConnection oDbCon;
            SqlCommand oDbCmd;
            try
            {
                bResult = true;
                tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                oDbCmd = new SqlCommand("STP_PRCbUpdateStockTotal", oDbCon);
                oDbCmd.CommandType = CommandType.StoredProcedure;
                oDbCmd.Parameters.Add("@pnStkMstID", SqlDbType.Int).Value = pnStkMstID1;
                oDbCmd.Parameters.Add("@pcStkMstTtl", SqlDbType.Decimal).Value = pcStkMstTtl2;

                bResult = Convert.ToBoolean(oDbCmd.ExecuteNonQuery());
                oDbCon.Close();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                bResult = false;

            }
            return bResult;
        }


        public static bool C_PRCbUpdateTotalStorepo(int pnStkMstID1, int pnStkTscTyp2, string ptStkTscVol3, string ptStkTscNte4, int pnUsrID5)
        {
            bool bResult;
            string tDbPath;

            SqlConnection oDbCon;
            SqlCommand oDbCmd;
            try
            {
                bResult = true;
                tDbPath = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AdaProcess;Integrated Security=true";
                oDbCon = new SqlConnection(tDbPath);
                oDbCon.Open();
                oDbCmd = new SqlCommand("STP_PRCbStockTransactionInsert", oDbCon);
                oDbCmd.CommandType = CommandType.StoredProcedure;
                oDbCmd.Parameters.Add("@pnStkMstID", SqlDbType.Int).Value = pnStkMstID1;
                oDbCmd.Parameters.Add("@pnStkTscTyp", SqlDbType.Int).Value = pnStkTscTyp2;
                oDbCmd.Parameters.Add("@pnStkTscVol", SqlDbType.NVarChar).Value = ptStkTscVol3;
                oDbCmd.Parameters.Add("@ptStkTscNte", SqlDbType.Text).Value = ptStkTscNte4;
                oDbCmd.Parameters.Add("@pnUsrID", SqlDbType.Decimal).Value = pnUsrID5;

                bResult = Convert.ToBoolean(oDbCmd.ExecuteNonQuery());
                oDbCon.Close();
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                bResult = false;

            }
            return bResult;
        }


        #endregion


    }
}
