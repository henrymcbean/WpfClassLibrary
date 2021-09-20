using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class ConsumptConsumptMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String ConSStyle { get; set; }
        public String ConSVariation { get; set; }
        public String ConSSizeKey { get; set; }
        public Int16? ConSPart { get; set; }
        public Int16? ConSType { get; set; }
        public String ConSCode { get; set; }
        public Int16? ConSColr { get; set; }
        public Int16? ConSColr1 { get; set; }
        public Int16? ConSSupl { get; set; }
        public Int16? ConSWhse { get; set; }
        public Int16? ConSLocn { get; set; }
        public String ConSConsumption { get; set; }
        #endregion Instance Properties

        public ConsumptConsumptMRec()
        {
            ID = 0;
            ConSConsumption = "d,32,1,32";
        }
    }
}
