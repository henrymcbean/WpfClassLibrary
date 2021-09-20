using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmcpasCPASMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? CPASOperNo { get; set; }
        public Int16? CPASCpaNo { get; set; }
        public String CPASLinkStr { get; set; }
        public Int16? CPASType { get; set; }
        public Int16? CPASNoOfDays { get; set; }

        #endregion Instance Properties
    }
}
