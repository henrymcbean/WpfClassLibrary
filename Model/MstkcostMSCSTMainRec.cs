using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MstkcostMSCSTMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? MSCSTMatType { get; set; }
        public String MSCSTMatCode { get; set; }
        public Int16? MSCSTMatColr { get; set; }
        public Int16? MSCSTMatColr1 { get; set; }
        public Int16? MSCSTMatSupl { get; set; }
        public Int16? MSCSTMatWhse { get; set; }
        public Int16? MSCSTMatLocn { get; set; }
        public String MSCSTMatUnit { get; set; }
        public Int32? MSCSTNoOfItems { get; set; }
        public double? MSCSTFactPrice { get; set; }
        public double? MSCSTPackCosts { get; set; }
        public double? MSCSTLocalCosts { get; set; }
        public double? MSCSTAgentComms { get; set; }
        public String MSCSTTransport { get; set; }
        public String MSCSTDuty { get; set; }
        public String MSCSTRent { get; set; }
        public String MSCSTLoading { get; set; }
        public String MSCSTUnLoading { get; set; }
        public String MSCSTClearance { get; set; }
        public String MSCSTHandling { get; set; }
        public String MSCSTOverheads { get; set; }
        public String MSCSTExtra { get; set; }
        public double? MSCSTWeaving { get; set; }
        public double? MSCSTDyeing { get; set; }
        public double? MSCSTFinishing { get; set; }
        public double? MSCSTPrinting { get; set; }
        public String MSCSTOther { get; set; }
        public double? MSCSTTotalCost { get; set; }
        public Int16? MSCSTCurrency { get; set; }
        public double? MSCSTCurrRate { get; set; }
        public double? MSCSTFactPriceF { get; set; }
        public double? MSCSTTransportF { get; set; }
        public String MSCSTRspMargPer { get; set; }
        public String MSCSTRspValue { get; set; }
        #endregion Instance Properties

        public MstkcostMSCSTMainRec()
        {
            ID = 0;
            MSCSTMatType = 0;
            MSCSTMatCode = "";
            MSCSTMatColr =
            MSCSTMatColr1 =
            MSCSTMatSupl =
            MSCSTMatWhse =
            MSCSTMatLocn = 0;

            MSCSTMatUnit = "";
            MSCSTNoOfItems = 0;

            MSCSTFactPrice =
            MSCSTPackCosts =
            MSCSTLocalCosts =
            MSCSTAgentComms = 0.0;

            MSCSTTransport =
            MSCSTDuty =
            MSCSTRent =
            MSCSTLoading =
            MSCSTUnLoading =
            MSCSTClearance =
            MSCSTHandling =
            MSCSTOverheads =
            MSCSTExtra = "d,4,1,4,,,,,";

            MSCSTWeaving =
            MSCSTDyeing =
            MSCSTFinishing =
            MSCSTPrinting = 0.0;

            MSCSTOther = "d,4,1,4,,,,,";

            MSCSTTotalCost = 0.0;


            MSCSTCurrency = 0;
            MSCSTCurrRate = 0.0;

            MSCSTFactPriceF =
            MSCSTTransportF = 0.0;
            
            MSCSTRspMargPer =
            MSCSTRspValue = "d,8,1,8,,,,,,,,,";
        }
    }
}
