using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class DocketDockInsts : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? DocketID { get; set; }
        public String DInsts { get; set; }
        #endregion Instance Properties
    }
}
