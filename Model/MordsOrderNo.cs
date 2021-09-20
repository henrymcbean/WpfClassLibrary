using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsOrderNo : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? PurchOrdNoIssd { get; set; }
        public Int32? PurchOrdNoOutd { get; set; }
        public Int32? PurchOrdNoComp { get; set; }
        public DateTime? OrderDate { get; set; }
        public String UserCode { get; set; }
        public Int16? CurrencyNo { get; set; }
        public double? CurrRate { get; set; }
        public Int16? MatSuplIssd { get; set; }
        public Int16? MatSuplOutd { get; set; }
        public Int16? MatSuplComp { get; set; }
        public Int16? OrdDeletionFlag { get; set; }
        public Int16? OrdCompletionFlag { get; set; }
        public Int16? OrdCancellingFlag { get; set; }
        public Int32? ExtraVar1 { get; set; }
        public Int32? ExtraVar2 { get; set; }
        public Int32? ExtraVar3 { get; set; }
        public Int16? ModeOfTransport { get; set; }
        public Int16? OrderPrinted { get; set; }
        public Int16? ConfirmedWithSupplier { get; set; }
        public Int16? ShippedBySupplier { get; set; }
        public Int16? VariousFlag1 { get; set; }
        public Int16? VariousFlag2 { get; set; }
        public Int16? VariousFlag3 { get; set; }
        public Int16? VariousFlag4 { get; set; }

        #endregion Instance Properties

        public String OrderRefIssd { get; set; }

        public MordsOrderNo()
        {
            ID = 0;
            ExtraVar3 = 0;
            MatSuplOutd = 0;
            MatSuplComp = 0;
            OrderPrinted = 0;
            VariousFlag1 = 0;
            VariousFlag2 = 0;
            VariousFlag3 = 0;
            VariousFlag4 = 0;
            PurchOrdNoIssd = 0;
            PurchOrdNoOutd = 0;
            PurchOrdNoComp = 0;
            OrdDeletionFlag = 1;
            OrdCompletionFlag = 1;
            OrdCancellingFlag = 1;
        }
    }
}
