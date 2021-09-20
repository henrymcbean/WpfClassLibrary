using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class OrdersOrdCosts : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? OrdColrsQtysID { get; set; }
        public Int16? OrdSpareFlag1 { get; set; }
        public Int16? OrdSpareFlag2 { get; set; }
        public Int16? OrdSpareFlag3 { get; set; }
        public Int16? OrdMatPart { get; set; }
        public Int16? OrdMatType { get; set; }
        public String OrdMatCode { get; set; }
        public Int16? OrdMatColr { get; set; }
        public Int16? OrdMatColr1 { get; set; }
        public Int16? OrdMatSupl { get; set; }
        public Int16? OrdMatWhse { get; set; }
        public Int16? OrdMatLocn { get; set; }
        public double? OrdCosting { get; set; }
        public double? OrdMatPrice { get; set; }
        public double? OrdClothWidth { get; set; }

        #endregion Instance Properties

        public OrdersOrdCosts()
        {
            ID = 0;
            OrdColrsQtysID = 0;
            OrdSpareFlag1 = 0;
            OrdSpareFlag2 = 0;
            OrdSpareFlag3 = 0;
            OrdMatColr1 = 0;
            OrdClothWidth = 0;
        }
    }
}
