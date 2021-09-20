using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersOrdStyles : ViewModelBase
    {
        #region Instance Properties

        public Int32? ID { get; set; }
        public Int32? OrdDelivAddrID { get; set; }
        public String OrdStyle { get; set; }
        public String OrdVarn { get; set; }
        public String OrdStVnIssued { get; set; }
        public String OrdStVnOutsdUnDock { get; set; }
        public String OrdStVnComplDock { get; set; }
        public String OrdStVnOutsdUnDesp { get; set; }
        public String OrdStVnComplDesp { get; set; }
        public String OrdStVnCancl { get; set; }
        public String OrdStyleDescr { get; set; }
        public Int32? OrdJStyleF2Ref { get; set; }
        public double? OrdTotalMatCost { get; set; }
        public double? OrdSellingPrice { get; set; }
        public String OrdMFabIssued { get; set; }
        public String OrdMFabOutsdUnDock { get; set; }
        public String OrdMFabComplDock { get; set; }
        public String OrdMFabOutsdUnDesp { get; set; }
        public String OrdMFabComplDesp { get; set; }
        public String OrdMFabCancl { get; set; }
        public String OrdStCustRef { get; set; }
        public DateTime? OrdStDelDate1 { get; set; }
        public DateTime? OrdStDelDate2 { get; set; }
        public double? OrdDisc1 { get; set; }
        public double? OrdDisc2 { get; set; }
        public double? OrdDisc3 { get; set; }
        #endregion Instance Properties

        public OrdersOrdStyles()
        {
            ID = 0;
            OrdStCustRef = "";
            OrdDelivAddrID = 0;
            OrdJStyleF2Ref = 0;
            OrdTotalMatCost = 0.0;
            OrdSellingPrice = 0.0;

            OrdStVnIssued = OrdStVnOutsdUnDock =
            OrdStVnComplDock = OrdStVnOutsdUnDesp =
            OrdStVnComplDesp = OrdStVnCancl = "";

            OrdMFabIssued = OrdMFabOutsdUnDock =
            OrdMFabComplDock = OrdMFabOutsdUnDesp =
            OrdMFabComplDesp = OrdMFabCancl = "";

            OrdDisc1 = OrdDisc2 = OrdDisc3 = 0.0;
        }
    }
}
