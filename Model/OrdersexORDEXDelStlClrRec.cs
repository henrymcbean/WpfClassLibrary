using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersexORDEXDelStlClrRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ORDEXSFileNumber { get; set; }
        public Int32? ORDEXSDeliveryIndex { get; set; }
        public String ORDEXSStyle { get; set; }
        public String ORDEXSVarn { get; set; }
        public Int16 ORDEXSColourNumber { get; set; }
        public String ORDEXSQtyPerCartonA { get; set; }

        #endregion Instance Properties
    }
}
