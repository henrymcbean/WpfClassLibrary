using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmcpasCPASOperDescRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? CPASDOperNo { get; set; }
        public Int16? CPASDCInitOperNo { get; set; }
        public String CPASDOperDescr { get; set; }
        public Int16? CPASDActionNumber { get; set; }
        public Int16? CPASDMatType { get; set; }

        #endregion Instance Properties
    }
}
