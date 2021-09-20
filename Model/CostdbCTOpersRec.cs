using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class CostdbCTOpersRec
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CostdbID { get; set; }
        public String CTOperNo { get; set; }
        public String CTOCostToMake { get; set; }
        public String CTOTimeToMake { get; set; }
        public double? CTOTotTimeToMake { get; set; }
        public double? CTOTotCostToMake { get; set; }
        #endregion Instance Properties
    }
}
