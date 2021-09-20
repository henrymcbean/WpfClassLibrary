using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class PackinstPACInstsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? PACMainRecID { get; set; }
        public Int32? Ordinal { get; set; } 
        public Int16? PACInstNo { get; set; }
        public String PACInsts { get; set; }
        #endregion Instance Properties
    }
}
