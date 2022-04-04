using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AdaMgMtLog;

namespace AdaStkMgmt.Process.ZPC
{
    internal class cCtrlAPI 
    {

        public static bool C_PRCbInsertStkTransaction(int pnStkMstID1, int pnStkTscTyp2, string ptStkTscVol3, string ptStkTscNte4, int pnUsrID5)
        {
            bool bResult;

            cmlCallAPI.cmlReqUpdateStockTransaction oPostStkTsc;
            HttpClient oClint;
            HttpResponseMessage oResponse;
            try
            {
                bResult = true;
                oPostStkTsc = new cmlCallAPI.cmlReqUpdateStockTransaction() { pnFNStkMstID = pnStkMstID1, pnFNStkTscTyp = pnStkTscTyp2, ptFTStkTscVol = ptStkTscVol3, ptFTStkTscNte = ptStkTscNte4, pdFDStkTscDte = DateTime.Now, pnFNUsrID = pnUsrID5 };
                oClint = new HttpClient();
                oClint.BaseAddress = new Uri("http://localhost:54554/");
                oResponse = oClint.PostAsJsonAsync("AdaPcApi/InsertStkTsc", oPostStkTsc).Result;
                if (oResponse.IsSuccessStatusCode)
                {
                    bResult = true;
                }
                else
                {

                    bResult = false;
                }
                return bResult;
            }
            catch (Exception oEx)
            {
                cSetLog.C_PRCbWriteLog(oEx.ToString());
                return bResult = false;
            }


        }
        public static bool C_PRCbUpdateStkTotal(int pnStkMstID1, decimal pcStkMstTtl2)
        {
            bool bResult;

            cmlCallAPI.cmlReqUpdateStockTotal oPostStkTtl;
            HttpClient oClint;
            HttpResponseMessage oResponse;
            try
            {
                bResult = true;
                oPostStkTtl = new cmlCallAPI.cmlReqUpdateStockTotal() { pnFNStkMstID = pnStkMstID1, pcFCStkMstTtl = pcStkMstTtl2 };
                oClint = new HttpClient();
                oClint.BaseAddress = new Uri("http://localhost:54554/");
                oResponse = oClint.PostAsJsonAsync("AdaPcApi/UpdateStkMstTtl", oPostStkTtl).Result;
                if (oResponse.IsSuccessStatusCode)
                {
                    bResult = true;
                }
                else
                {

                    bResult = false;
                }
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
