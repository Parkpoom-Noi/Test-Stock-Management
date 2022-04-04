using System;
using System.Data;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    public class cCtrlStorePo
    {
        public static DataTable C_PRCoGetDatStkMaster()
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT * FROM [dbo].[STP_PRCbGetStockMaster]");
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }
        public static DataTable C_PRCoGetDatStkSearch(string ptStkScrh1)
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT  \r\n" +
                   "ROW_NUMBER() OVER(ORDER BY A1.[FNStkMstID] ASC) AS 'No.'  \r\n" +
                 " , A1.[FNStkMstID] as 'Part number'  \r\n" +
                 " , A1.[FTStkMstNme] as 'Part name' \r\n" +
                 " , A1.[FCStkMstTtl] as 'Stock Total' \r\n" +
                 " , A2.[FTStkUntTxt] as 'Part unit' \r\n" +
                 " , A1.[FTStkMstNte] as 'Note' \r\n" +
                 " , A3.[FTUsrNme] as 'Add by' \r\n" +
             " FROM [dbo].[TPCMStkMst] A1 \r\n" +
             " left join[TPCMStkUnt] A2 ON(A1.[FNStkUntID] = A2.[FNStkUntID]) \r\n" +
             " Left Join[TPCMUser] A3 ON(A1.[FNUsrID] = A3.[FNUsrID]) \r\n" +
             " WHERE \r\n" +
               " A1.[FNStkMstID] LIKE '%" + ptStkScrh1 + "%' OR \r\n" +
               " A1.[FTStkMstNme] LIKE '%" + ptStkScrh1 + "%'  OR \r\n" +
               " A1.[FCStkMstTtl] LIKE '%" + ptStkScrh1 + "%'  OR \r\n" +
               " A2.[FTStkUntTxt] LIKE '%" + ptStkScrh1 + "%'  OR \r\n" +
               " A1.[FTStkMstNte] LIKE '%" + ptStkScrh1 + "%' OR \r\n" +
               " A3.[FTUsrNme] LIKE '%" + ptStkScrh1 + "%' ");
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }
        public static DataTable C_PRCoGetDatStkTransaction()
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT * FROM  [dbo].[STP_PRCbGetStockTransaction]  ORDER BY [No.] ASC");
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }
        public static bool C_PRCbInsertStorePo(string ptStkMstNme1, string ptStkMstNte2, decimal pcStkMstTtl3
                                        , int pnStkUntID4, int pnUsrID5, string ptStmTyp6)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_PRCbExcuteStorePo(0, ptStkMstNme1, ptStkMstNte2, pcStkMstTtl3, pnStkUntID4, pnUsrID5, "Ist");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
        public static bool C_PRCbDeleteStorePo(int pnStkMstID1)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_PRCbExcuteStorePo(pnStkMstID1, " ", " ", 0, 0, 0, "Dlt");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
        public static DataTable C_PRCoGetDatStkMasterStorePo(int pnStkMstID1)
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectStorePo(pnStkMstID1);
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }
        public static bool C_PRCbUpdateStorePo(int pnStkMstID1, string ptStkMstNme2, string ptStkMstNte3, decimal pcStkMstTtl4
                                        , int pnStkUntID5)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_PRCbExcuteStorePo(pnStkMstID1, ptStkMstNme2, ptStkMstNte3, pcStkMstTtl4, pnStkUntID5, 0, "Udt");
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }


        public static bool C_PRCbUpdateTotalStorePo(int pnStkMstID1, decimal pcStkMstTtl2)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_PRCbExcuteTransactionStorepo(pnStkMstID1, pcStkMstTtl2);
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
        public static bool C_PRCbInsertTransactionStorePo(int pnStkMstID1, int pnStkTscTyp2, string ptStkTscVol3, string ptStkTscNte4, int pnUsrID5)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_PRCbUpdateTotalStorepo(pnStkMstID1, pnStkTscTyp2, ptStkTscVol3, ptStkTscNte4, pnUsrID5);
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }
        }
    }
}
