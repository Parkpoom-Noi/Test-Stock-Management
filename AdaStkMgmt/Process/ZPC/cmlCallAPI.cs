using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    internal class cmlCallAPI
    {
        public class cmlResStockTransactionSelect
        {
            public Nullable<long> rnNo_ { get; set; }
            public int rnTransaction_ID { get; set; }
            public int rnPart_Number { get; set; }
            public string rtPart_name { get; set; }
            public string rtTransaction_type { get; set; }
            public string rtTransaction_volume { get; set; }
            public string rtTransaction_note { get; set; }
            public Nullable<System.DateTime> rdTransaction_Date { get; set; }
            public string rtTransaction_by { get; set; }
        }
        public class cmlReqUpdateStockTransaction 
        {
            public int pnFNStkTscID { get; set; }
            public int pnFNStkMstID { get; set; }
            public Nullable<int> pnFNStkTscTyp { get; set; }
            public string ptFTStkTscVol { get; set; }
            public string ptFTStkTscNte { get; set; }
            public Nullable<System.DateTime> pdFDStkTscDte { get; set; }
            public int pnFNUsrID { get; set; }
             
        }
        public class cmlReqUpdateStockTotal 
        {
            public int pnFNStkMstID { get; set; }
            public string ptFTStkMstNme { get; set; }
            public string ptFTStkMstNte { get; set; }
            public decimal pcFCStkMstTtl { get; set; }
            public int pnFNStkUntID { get; set; }
            public int pnFNUsrID { get; set; }
            public System.DateTime pdFDStkMstDteAdd { get; set; }
        }

    }
}
