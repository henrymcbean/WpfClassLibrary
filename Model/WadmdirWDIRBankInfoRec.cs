using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class WadmdirWDIRBankInfoRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ClientID { get; set; }
        public String WDIRBBank { get; set; }
        public String WDIRBAddress { get; set; }
        public Int32? WDIRBCurrency { get; set; }
        public String WDIRBSortCode { get; set; }
        public String WDIRBSwiftNo { get; set; }
        public String WDIRBAccNo { get; set; }
        public String WDIRBBacs { get; set; }

        #endregion Instance Properties
    }
}
