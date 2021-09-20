using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmpacksPKSMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String PKSPackKey { get; set; }
        public String PKSSizeKey { get; set; }
        public String PKSPackQty { get; set; }

        #endregion Instance Properties
    }
}
