using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MatsupldMATSUPLDSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MATSUPLDMainRecID { get; set; }
        public Int16? MATSUPLDMatType { get; set; }
        public String MATSUPLDMatCode { get; set; }
        public Int16? MATSUPLDMatColr { get; set; }
        public Int16? MATSUPLDMatColr1 { get; set; }
        public Int16? MATSUPLDMatSupl { get; set; }
        public Int16? MATSUPLDMatWhse { get; set; }
        public Int16? MATSUPLDMatLocn { get; set; }
        public double? MATSUPLDMatSupplied { get; set; }
        public String MATSUPLDSuppliedSizes { get; set; }
        public String MATSUPLDInvoiceNo { get; set; }

        #endregion Instance Properties
    }
}
