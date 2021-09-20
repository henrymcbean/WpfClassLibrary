using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DockrollDKRLMainData
    {
        #region Instance Properties

        public Int32? ID { get; set; }
        public Int32? DKRLDocketNo { get; set; }
        public DateTime? DKRLDate { get; set; }
        public Int32? DKRLTime { get; set; }
        public Int16? DKRLMatPart { get; set; }
        public Int16? DKRLMatType { get; set; }
        public String DKRLMatCode { get; set; }
        public Int16? DKRLMatColr { get; set; }
        public Int16? DKRLMatColr1 { get; set; }
        public Int16? DKRLMatSupl { get; set; }
        public Int16? DKRLMatWhse { get; set; }
        public Int16? DKRLMatLocn { get; set; }

        #endregion Instance Properties
    }
}
