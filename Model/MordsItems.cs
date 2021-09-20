using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsItems : ViewModelBase
    {
        #region Instance Properties

        public Int32 ID { get; set; }
        public Int32? OrderNoID { get; set; }
        public Int16? MatType { get; set; }
        public String MatCodeIssd { get; set; }
        public String MatCodeOutd { get; set; }
        public String MatCodeComp { get; set; }
        public Int16? MatColr { get; set; }
        public Int16? MatColr1 { get; set; }
        public Int16? MatWhse { get; set; }
        public Int16? MatLocn { get; set; }
        public double? MatPrice { get; set; }
        public double? MatPriceF { get; set; }
        public String MatUnit { get; set; }
        public Int32? MatValOrdUnit { get; set; }
        public String MatSzKey { get; set; }
        public Int16? DelivAddrWhse { get; set; }
        public double? OrderedAmount { get; set; }
        public double? ReceivedAmount { get; set; }
        public double? RecvdAmntInRolls { get; set; }
        public double? DiscPer { get; set; }
        public double? Discount { get; set; }
        public double? DiscountF { get; set; }
        public double? DelivCharges { get; set; }
        public double? DelivChargesF { get; set; }
        public double? VatPer { get; set; }
        public double? VatRate { get; set; }
        public double? VatRateF { get; set; }
        public DateTime? DelivDateFromIssd { get; set; }
        public DateTime? DelivDateToIssd { get; set; }
        public Int32? FileNoIssd { get; set; }
        public Int32? FileNoOutd { get; set; }
        public Int32? FileNoComp { get; set; }
        public Int16? CustNo { get; set; }
        public String Style { get; set; }
        public String Varn { get; set; }
        public Int16? ItemDeletionFlag { get; set; }
        public Int16? ItemCompletionFlag { get; set; }
        public Int16? ItemCancellingFlag { get; set; }
        public Int16? Reserve1 { get; set; }
        public Int16? Reserve2 { get; set; }
        public Int16? MONoOfDays { get; set; }
        public Int16? MOTypeOfDiscount { get; set; }

        #endregion Instance Properties

        public String OrderReference { get; set; }
        public String FileNoIssdStatus { get; set; }
        public double MinOrderQty { get; set; }
        public double ItemTotal { get; set; }
        public double ItemTotalF { get; set; }
        public double OrderTotal { get; set; }
        public double OrderTotalF { get; set; }
        public short FactoryNo { get; set; }
        public string FactoryNoDesc { get; set; }

        public MordsItems()
        {
            MatColr1 = 0;
            OrderNoID = 0;
            FileNoOutd = 0;
            FileNoComp = 0;

            Reserve1 = 1;
            Reserve2 = 1;
            ReceivedAmount = 0.0;
            RecvdAmntInRolls = 0.0;

            ItemDeletionFlag = 1;
            ItemCompletionFlag = 1;
            ItemCancellingFlag = 1;

            MatSzKey = "";
            MatCodeIssd = "";
            MOTypeOfDiscount = 2;
            DelivDateFromIssd = DateTime.Now;
            DelivDateToIssd = DateTime.Now;
        }
    }
}
