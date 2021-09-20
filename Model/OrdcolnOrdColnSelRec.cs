using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdcolnOrdColnSelRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrdColnSRecID { get; set; }
        public Int32? OCNSFileNo { get; set; }
        public Int16? OCNSCustNo { get; set; }
        public Int16? OCNSDelPoint { get; set; }
        public DateTime? OCNSDelDate { get; set; }
        public Int16? OCNSColrNo { get; set; }
        public String OCNSColnQtys { get; set; }
        public String OCNSUnDockQtys { get; set; }
        public String OCNSDockQtys { get; set; }
        public String OCNSRecvQtys { get; set; }
        public Int16? OCNSWhse { get; set; }
        public Int16? OCNSLocn { get; set; }

        #endregion Instance Properties

        // OrdersOrdColrsQtys ID & Select Flag
        public Int32 OrdColrsQtysID { get; set; }
        public bool Sel { get; set; }

        public OrdcolnOrdColnSelRec()
        {
            ID = 0;
            Sel = false;
        }
    }
}
