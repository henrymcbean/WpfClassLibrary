using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DocktboxDBC_BoxGroupRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MainRecID { get; set; }
        public Int16? DBC_BoxGroupNumber { get; set; }
        public String DBC_BoxInformation { get; set; }
        public double? DBC_GrossWeight { get; set; }
        public double? DBC_NetWeight { get; set; }
        public String DBC_Notes { get; set; }
        public Int16? DBC_NoOfBoxes { get; set; }

        #endregion Instance Properties
    }
}
