using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class WGmateConfig
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public String ImagePath { get; set; }
        public String Picture { get; set; }
        public String Sketch { get; set; }
        public String CareInstruction { get; set; }
        public String Material { get; set; }
        public String Scanned { get; set; }
        public String SAPDir { get; set; }
        public Int16? DeliveryDays { get; set; }
        public String CompanyLine1 { get; set; }
        public String CompanyLine2 { get; set; }
        public String CompanyLine3 { get; set; }
        public String CompanyLine4 { get; set; }
        public String CompanyLine5 { get; set; }
        public String CompanyLine6 { get; set; }
        public String Conditions1 { get; set; }
        public String Conditions2 { get; set; }
        public String Conditions3 { get; set; }
        public String Conditions4 { get; set; }
        public String Conditions5 { get; set; }
        public String Conditions6 { get; set; }
        public Int16? CriticalPathType { get; set; }

        #endregion Instance Properties
    }
}
