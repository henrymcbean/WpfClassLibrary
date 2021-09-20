using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdcolnOrdColnSRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrdColnMRecID { get; set; }
        public Int16? OCNColrNo { get; set; }
        public String OCNColnQtys { get; set; }
        public String OCNUnDockQtys { get; set; }
        public String OCNDockQtys { get; set; }
        public String OCNRecvQtys { get; set; }
        public Int16? OCNDkClFlag { get; set; }

        #endregion Instance Properties

        // Select FLag
        public bool Sel { get; set; }

        public OrdcolnOrdColnSRec()
        {
            ID = 0;
            Sel = false;
            OCNDkClFlag = 0;
            OrdColnMRecID = 0;
        }
    }
}
