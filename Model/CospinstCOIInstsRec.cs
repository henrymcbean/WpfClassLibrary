using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CospinstCOIInstsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MainRecID { get; set; }
        public Int32 Ordinal { get; set; } 
        public Int16? COIInstNo { get; set; }
        public String COIInsts { get; set; }
        #endregion Instance Properties

        public CospinstCOIInstsRec()
        {
            MainRecID = 0;
        }
    }
}
