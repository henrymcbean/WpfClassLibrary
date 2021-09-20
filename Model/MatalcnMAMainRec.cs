using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MatalcnMAMainRec
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int16? MACustNo { get; set; }
        public Int32? MAFileNo { get; set; }
        public Int16? MADelAddr { get; set; }
        public String MAStyle { get; set; }
        public String MAVarn { get; set; }
        public DateTime? MADelDate { get; set; }
        public Int32? MAQnty { get; set; }
        public Int16? MAMFabricFlag { get; set; }
        public Int16? MAMatType { get; set; }
        public String MAMatCode { get; set; }
        public Int16? MAMatColr { get; set; }
        public Int16? MAMatColr1 { get; set; }
        public Int16? MAMatSupl { get; set; }
        public Int16? MAMatWhse { get; set; }
        public Int16? MAMatLocn { get; set; }
        public String MAMatSizeKey { get; set; }
        public double? MAMatCost { get; set; }
        public double? MACosting { get; set; }
        public double? MAMatRequired { get; set; }
        public String MAMatReqrdSizes { get; set; }
        public double? MAMatAllocated { get; set; }
        public String MAMatAllocSizes { get; set; }

        #endregion Instance Properties
    }
}
