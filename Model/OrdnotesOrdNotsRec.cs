using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdnotesOrdNotsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrdNFlNo { get; set; }
        public String OrdMNotes { get; set; }

        #endregion Instance Properties

        public OrdnotesOrdNotsRec()
        {
            ID = 0;
            OrdNFlNo = 0;
        }
    }
}
