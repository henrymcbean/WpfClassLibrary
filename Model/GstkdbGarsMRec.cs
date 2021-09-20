using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GstkdbGarsMRec
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? GTFileNo { get; set; }
        public String GTStyle { get; set; }
        public String GTVarn { get; set; }
        public String GTStyleVarn { get; set; }
        public String GTStyleDescr { get; set; }
        public String GTMainFabric { get; set; }
        public Int16? GTColrNo { get; set; }
        public Int16? GTColrNo1 { get; set; }
        public Int16? GTWhse { get; set; }
        public Int16? GTLocn { get; set; }
        public String GTSizeKey { get; set; }
        public double? GTPrice { get; set; }
        public double? GTRSPrice { get; set; }
        public Int16? GTGarType { get; set; }
        public Int16? GTOrdType { get; set; }
        public Int16? GTMinExpSz { get; set; }
        public Int16? GTMinUkSz { get; set; }
        public String GTExpSzKey { get; set; }
        public String GTUkSzKey { get; set; }
        public String GTLineNumber { get; set; }
        public String GTBarCodeNumber { get; set; }
        public String GTQtys { get; set; }

        #endregion Instance Properties
    }
}
