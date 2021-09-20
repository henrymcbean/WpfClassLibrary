using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersexORDEXAdditions1Rec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ORDEXA1FileNumber { get; set; }
        public Int16? ORDEXA1UseOrgCosting { get; set; }

        #endregion Instance Properties

        public OrdersexORDEXAdditions1Rec()
        {
            ID = 0;
            ORDEXA1UseOrgCosting = 0;
        }
    }
}
