using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OverheadOVHSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MainRecID { get; set; }
        public String OVHDescr { get; set; }
        public double? OVHPercent { get; set; }
        public double? OVHAmount { get; set; }
        #endregion Instance Properties

        public OverheadOVHSiblRec()
        {
            ID = 0;
            MainRecID = 0;
        }
    }
}
