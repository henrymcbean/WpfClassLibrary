using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class SzmappngSzMappingRec : XmlConvertor
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String MSZSStyle { get; set; }
        public String MSZSVariation { get; set; }
        public Int16? MSZSPart { get; set; }
        public Int16? MSZSType { get; set; }
        public String MSZSCode { get; set; }
        public Int16? MSZSColour { get; set; }
        public Int16? MSZSColour1 { get; set; }
        public Int16? MSZSSupplier { get; set; }
        public Int16? MSZSWhse { get; set; }
        public Int16? MSZSLocn { get; set; }
        public String MSZSMatSizeKey { get; set; }
        public String MSZSGarSizeKey { get; set; }
        public String MSZSSizes { get; set; }
        #endregion Instance Properties
    }
}
