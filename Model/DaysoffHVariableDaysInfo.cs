using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DaysoffHVariableDaysInfo
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? HHeaderInfoID { get; set; }
        public DateTime? H_VDateFrom { get; set; }
        public DateTime? H_VDateTo { get; set; }
        public double? H_VHours { get; set; }

        #endregion Instance Properties
    }
}
