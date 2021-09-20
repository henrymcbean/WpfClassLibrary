using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmlinenoGMLNMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? GMLNFileNo { get; set; }
        public Int16? GMLNDelAddr { get; set; }
        public String GMLNStyle { get; set; }
        public String GMLNVarn { get; set; }
        public Int16? GMLNColrNo { get; set; }
        public Int16? GMLNColrNo1 { get; set; }
        public Int16? GMLNLineIndex { get; set; }
        public String GMLNLineNo { get; set; }

        #endregion Instance Properties
    }
}
