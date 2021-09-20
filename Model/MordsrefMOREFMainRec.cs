using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MordsrefMOREFMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MOREFOrderNo { get; set; }
        public String MOREFOrderRefIssd { get; set; }
        public String MOREFOrderRefOutd { get; set; }
        public String MOREFOrderRefComp { get; set; }
        public String MOREFOrderTypeIssd { get; set; }
        public String MOREFOrderTyepOutd { get; set; }
        public String MOREFOrderTypeComp { get; set; }
        public Int32? MOREFMatCsOrdNoIssd { get; set; }
        public Int32? MOREFMatCsOrdNoOutd { get; set; }
        public Int32? MOREFMatCsOrdNoComp { get; set; }
        public Int16? MOREFMatCustNoIssd { get; set; }
        public Int16? MOREFMatCustNoOutd { get; set; }
        public Int16? MOREFMatCustNoComp { get; set; }
        #endregion Instance Properties
    }
}
