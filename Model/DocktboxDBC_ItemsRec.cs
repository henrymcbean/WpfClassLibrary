using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DocktboxDBC_ItemsRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ItemsRecID { get; set; }
        public double? DBC_Quantity { get; set; }
        public Int16? DBC_MatType { get; set; }
        public String DBC_MatCode { get; set; }
        public String DBC_MatDescription { get; set; }
        public Int16? DBC_MatColour { get; set; }
        public Int32? DBC_MatSupplier { get; set; }
        public Int16? DBC_MatWhse { get; set; }
        public Int16? DBC_MatLocn { get; set; }
        public double? DBC_MatPrice { get; set; }
        public Int32? DBC_NoOfRolls { get; set; }
        public double? DBC_MatWeight { get; set; }

        #endregion Instance Properties
    }
}
