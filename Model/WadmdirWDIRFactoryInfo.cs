using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class WadmdirWDIRFactoryInfo
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ClientID { get; set; }
        public Int16? WDIRQualityOfWork { get; set; }
        public double? WDIRMaxStDaysPerWk { get; set; }
        public double? WDIRAvailStDaysPerWk1 { get; set; }
        public double? WDIRAvailStDaysPerWk2 { get; set; }
        public double? WDIRAvailStDaysPerWk3 { get; set; }
        public double? WDIRAvailStDaysPerWk4 { get; set; }
        public double? WDIRStDaysOutstanding { get; set; }
        public double? WDIRDaysForCompletion { get; set; }

        #endregion Instance Properties
    }
}
