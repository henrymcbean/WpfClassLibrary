using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersOrdDelivAddr : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrderID { get; set; }
        public Int16? DelAddress { get; set; }
        public Int16? DelAddroutUnDock { get; set; }
        public Int16? DelAddrcomDock { get; set; }
        public Int16? DelAddroutUnDesp { get; set; }
        public Int16? DelAddrcomDesp { get; set; }
        public Int16? DelAddrcan { get; set; }
        public Int16? OrdInvcAddress { get; set; }
        public DateTime? OrdDelDate1Issd { get; set; }
        public DateTime? OrdDlDat2Issd { get; set; }
        public DateTime? OrdDlDat2OutsdUnDock { get; set; }
        public DateTime? OrdDlDat2ComplDock { get; set; }
        public DateTime? OrdDlDat2OutsdUnDesp { get; set; }
        public DateTime? OrdDlDat2ComplDesp { get; set; }
        public DateTime? OrdDlDat2Cancl { get; set; }
        public Int16? OrdMinExpSz { get; set; }
        public Int16? OrdMinUkSz { get; set; }
        public String OrdExpSzKey { get; set; }
        public String OrdUkSzKey { get; set; }
        public String OrdOrderReference { get; set; }
        #endregion Instance Properties

        public OrdersOrdDelivAddr()
        {
            ID = 0;
            OrderID = 0;
            DelAddress = 0;
            DelAddroutUnDock = 0;
            DelAddrcomDock = 0;
            DelAddroutUnDesp = 0;
            DelAddrcomDesp = 0;
            DelAddrcan = 0;
            OrdInvcAddress = 0;
            OrdMinExpSz = 0;
            OrdMinUkSz = 0;
            DelAddrcan = 0;
            OrdExpSzKey = "";
        }
    }
}
