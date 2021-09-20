using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class SelpriceSPRSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? SPRMainRecID { get; set; }
        public String SPRDescr { get; set; }
        public double? SPRPercent { get; set; }
        public double? SPRAmount { get; set; }

        #endregion Instance Properties

        public SelpriceSPRSiblRec()
        {
            ID = 0;
            SPRMainRecID = 0;
        }
    }
}
