using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class UserdcktUserDcktMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? UDRecordNumber { get; set; }
        public String UDUserCode { get; set; }
        public String UDUserName { get; set; }
        public DateTime? UDDate { get; set; }
        public Int32? UDTime { get; set; }
        public Int32? UDDocketNumber { get; set; }

        #endregion Instance Properties

        public UserdcktUserDcktMainRec()
        {
            ID = 0;
            UDRecordNumber = 0;
            UDDocketNumber = 0;
        }
    }
}
