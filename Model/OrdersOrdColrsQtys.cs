using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersOrdColrsQtys : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrdStylesID { get; set; }
        public Int16? OrdColrNo { get; set; }
        public Int16? OrdColrNo1 { get; set; }
        public String OrdIssdQtys { get; set; }
        public Int32? OrdIssdTotal { get; set; }
        public String OrdUnDockQtys { get; set; }
        public Int32? OrdUnDockTotal { get; set; }
        public String OrdDockQtys { get; set; }
        public Int32? OrdDockTotal { get; set; }
        public String OrdUnDespQtys { get; set; }
        public Int32? OrdUnDespTotal { get; set; }
        public String OrdDespQtys { get; set; }
        public Int32? OrdDespTotal { get; set; }
        public double? OrdMatCost { get; set; }
        #endregion Instance Properties

        // Select Flag
        public bool Sel { get; set; }
        public String GMLNLineNo { get; set; }
        public int GMLNLineNoID { get; set; }
        public short GMLNLineIndex { get; set; }

        public OrdersOrdColrsQtys()
        {
            ID = 0;
            OrdStylesID = 0;
            OrdColrNo1 = 0;

            OrdIssdTotal = OrdUnDockTotal =
            OrdDockTotal = OrdUnDespTotal =
            OrdDespTotal = 0;

            OrdIssdQtys = OrdUnDockQtys =
            OrdDockQtys = OrdUnDespQtys =
            OrdDespQtys = "l,32,1,32,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";

            GMLNLineIndex = 0;
            GMLNLineNoID = 0;
            GMLNLineNo = "";
        }
    }
}
