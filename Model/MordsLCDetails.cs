using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsLCDetails : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? PurchOrdNoIssd { get; set; }
        public String LCtext { get; set; }
        #endregion Instance Properties
    }
}
