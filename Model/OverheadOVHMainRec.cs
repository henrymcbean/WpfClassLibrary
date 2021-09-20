using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OverheadOVHMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String OVHStyle { get; set; }
        public String OVHVarn { get; set; }
        #endregion Instance Properties
    }
}
