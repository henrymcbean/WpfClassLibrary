using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class CostdbCTNotsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32 CostdbID { get; set; }
        public String CTNotes { get; set; }
        #endregion Instance Properties
    }
}
