using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CusprefsCusPrefsMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String CSPRFStyle { get; set; }
        public String CSPRFVarn { get; set; }
        public Int16? CSPRFMatPart { get; set; }
        public Int16? CSPRFMatType { get; set; }
        public String CSPRFMatCode { get; set; }
        public Int16? CSPRFMatColr { get; set; }
        public Int16? CSPRFMatColr1 { get; set; }
        public Int16? CSPRFMatSupl { get; set; }
        public Int16? CSPRFMatWhse { get; set; }
        public Int16? CSPRFMatLocn { get; set; }
        #endregion Instance Properties

        public CusprefsCusPrefsMRec()
        {
            ID = 0;
        }
    }
}
