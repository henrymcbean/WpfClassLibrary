using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GinvoiceINVMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? INVInvoiceNo { get; set; }
        public String INVCustAgent { get; set; }
        public Int16? INVInvcFlag { get; set; }
        public Int16? INVDespFlag { get; set; }
        public Int32? INVCustNo { get; set; }
        public Int32? INVInvcAddress { get; set; }
        public String INVInvcAddress1 { get; set; }
        public String INVInvcAddress2 { get; set; }
        public String INVInvcAddress3 { get; set; }
        public String INVInvcAddress4 { get; set; }
        public String INVInvcAddress5 { get; set; }
        public Int32? INVDelvAddress { get; set; }
        public String INVDelvAddress1 { get; set; }
        public String INVDelvAddress12 { get; set; }
        public String INVDelvAddress13 { get; set; }
        public String INVDelvAddress14 { get; set; }
        public String INVDelvAddress15 { get; set; }
        public double? INVInvoiceDisc { get; set; }
        public Int32? INVAgentNo { get; set; }
        public double? INVCommission { get; set; }
        public Int32? INVNoOfDays { get; set; }
        public double? INVCarriage { get; set; }
        public Int16? INVInvcVatNo { get; set; }
        public double? INVInvcVatRate { get; set; }
        public double? INVVatAmount { get; set; }
        public Int16? INVNominalNo { get; set; }
        public Int16? INVCurrency { get; set; }
        public double? INVCurrRate { get; set; }
        public DateTime? INVDespDate1 { get; set; }
        public DateTime? INVDespDate2 { get; set; }
        public double? INVNetTotalValue { get; set; }
        public double? INVVatTotalValue { get; set; }
        public double? INVGrossTotalValue { get; set; }
        public Int16? INVOutstFlag { get; set; }
        public Int16? INVUnPaidFlag { get; set; }
        public Int16? INVPaidFlag { get; set; }
        #endregion Instance Properties
    }
}
