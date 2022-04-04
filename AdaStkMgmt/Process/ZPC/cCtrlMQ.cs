using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    internal class cCtrlMQ
    {

        public static DataTable C_PRCoGetDatMqLog()
        {
            DataTable oDbTbl;
            try
            {
                oDbTbl = new DataTable();
                oDbTbl = cDbConnect.C_GEToSelectFromDB("SELECT [FNLgnLogID] AS 'Log ID' \r\n" +
                                  ",[FTLgnLogTxt] AS 'Text from MQ' \r\n" +
                                  ",[FDLgnLogDte] AS 'Date login' \r\n" +
                              "FROM [dbo].[TPCTLgnLog]" +
                              "ORDER BY [FNLgnLogID] DESC");
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return oDbTbl = null;
            }

        }

        public static bool C_PRCbInsertMqLog(string ptLogTxt1)
        {
            bool bResult;
            try
            {
                bResult = true;
                bResult = cDbConnect.C_CHKbExecuteFromDB("INSERT INTO [dbo].[TPCTLgnLog] \r\n" +
                                       "([FTLgnLogTxt] \r\n" +
                                       ",[FDLgnLogDte]) \r\n" +
                                "VALUES \r\n" +
                                       "( '" + ptLogTxt1 + "' \r\n" +
                                       ", GETDATE()  )");
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
