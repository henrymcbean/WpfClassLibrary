using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MatsbinMatBinMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? BMatType { get; set; }
        public String BMatCode { get; set; }
        public Int16? BMatColr { get; set; }
        public Int16? BMatColr1 { get; set; }
        public Int16? BMatSupl { get; set; }
        public Int16? BMatWhse { get; set; }
        public Int16? BMatLocn { get; set; }
        public Int16? BMatBin { get; set; }
        public String BMatBinName { get; set; }

        #endregion Instance Properties
    }
}
