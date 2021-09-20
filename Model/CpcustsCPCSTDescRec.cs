using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CpcustsCPCSTDescRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CPCSTDCustNo { get; set; }
        public Int16? CPCSTDCpaNo { get; set; }
        public String CPCSTDShortDescr { get; set; }
        public String CPCSTDLongDescr { get; set; }

        #endregion Instance Properties
    }
}
