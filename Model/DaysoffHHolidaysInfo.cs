using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DaysoffHHolidaysInfo
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? HHeaderInfoID { get; set; }
        public DateTime? H_HDateFrom { get; set; }
        public DateTime? H_HDateTo { get; set; }

        #endregion Instance Properties
    }
}
