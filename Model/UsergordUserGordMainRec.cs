using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    class UsergordUserGordMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? UGRecordNumber { get; set; }
        public String UGUserCode { get; set; }
        public String UGUserName { get; set; }
        public DateTime? UGDate { get; set; }
        public DateTime? UGTime { get; set; }
        public Int32? UGFileNumber { get; set; }

        #endregion Instance Properties
    }
}
