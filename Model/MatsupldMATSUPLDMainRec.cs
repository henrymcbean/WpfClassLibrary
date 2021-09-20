using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MatsupldMATSUPLDMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MATSUPLDDocketNumber { get; set; }
        public Int32? MATSUPLDFactoryNumber { get; set; }
        public DateTime? MATSUPLDDate { get; set; }
        public Int32? MATSUPLDTime { get; set; }

        #endregion Instance Properties
    }
}
