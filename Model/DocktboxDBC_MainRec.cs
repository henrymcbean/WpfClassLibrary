using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DocktboxDBC_MainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? DBC_TransNumber { get; set; }
        public DateTime? DBC_TransDate { get; set; }
        public DateTime? DBC_TransDateRev { get; set; }
        public Int32? DBC_Factory { get; set; }
        public Int32? DBC_Transporter { get; set; }
        public Int16? DBC_Country { get; set; }
        public Int16? DBC_CompletionFlag { get; set; }

        #endregion Instance Properties
    }
}
