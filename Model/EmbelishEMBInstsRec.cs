using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class EmbelishEMBInstsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? EMBMainRecID { get; set; }
        public Int32 Ordinal { get; set; } 
        public Int16? EMBInstNo { get; set; }
        public String EMBInsts { get; set; }
        #endregion Instance Properties
    }
}
