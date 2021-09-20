using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GinvoiceINVColourRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? INVStyleID { get; set; }
        public Int16? INVColourNo { get; set; }
        public String INVQntys { get; set; }
        public String INVLineNo { get; set; }
        public double? INVPrice { get; set; }
        public Int16? INVWhse { get; set; }
        public Int16? INVLocn { get; set; }
        #endregion Instance Properties

        public List<long> Qntys { get; set; }    // 32 longs 
    }
}
