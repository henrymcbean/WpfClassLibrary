using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GopacksGOPKSSiblRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? GOPKSMainRecID { get; set; }
        public String GOPKSPackKey { get; set; }
        public Int16? GOPKSPacksMult { get; set; }
        public String GOPKSSizeKey { get; set; }
        public String GOPKSPackQty { get; set; }

        #endregion Instance Properties
    }
}
