using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CpcustsCPCSTOperDescRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CPCSTODCustNo { get; set; }
        public Int16? CPCSTODOperNo { get; set; }
        public String CPCSTODOperDescr { get; set; }

        #endregion Instance Properties
    }
}
