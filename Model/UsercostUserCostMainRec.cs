using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class UsercostUserCostMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? UCRecordNumber { get; set; }
        public String UCUserCode { get; set; }
        public String UCUserName { get; set; }
        public DateTime? UCDate { get; set; }
        public Int32? UCTime { get; set; }
        public String UCStyleVarn { get; set; }
        public String UCStyle { get; set; }
        public String UCVarn { get; set; }

        #endregion Instance Properties

        public UsercostUserCostMainRec()
        {
            ID = 0;
            UCRecordNumber = 0;
        }
    }
}
