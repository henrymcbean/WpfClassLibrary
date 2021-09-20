using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersexORDEXMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ORDEXFileNumber { get; set; }
        public Int16? ORDEXDeliveryIndex { get; set; }
        public String ORDEXSeason { get; set; }
        public Int16? ORDEXYear { get; set; }
        public String ORDEXSupplierCode { get; set; }
        public String ORDEXFactoryCode { get; set; }
        public Int32? ORDEXQtyPerCarton { get; set; }
        public Int32? ORDEXLeadTimeDays { get; set; }
        public String ORDEXGBSRefNo { get; set; }
        public String ORDEXCustCode { get; set; }
        public String ORDEXCustCONo { get; set; }
        public String ORDEXUCustCode { get; set; }
        public String ORDEXUCustCoNo { get; set; }
        public String ORDEXOrderCharacter { get; set; }
        public String ORDEXOrderChar { get; set; }
        public String ORDEXDSNo { get; set; }
        public String ORDEXCustDelivSeq { get; set; }
        public String ORDEXDeliveryAddress { get; set; }
        public String ORDEXShippingMode { get; set; }

        #endregion Instance Properties
    }
}
