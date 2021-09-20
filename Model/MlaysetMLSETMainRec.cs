using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MlaysetMLSETMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? MLSET_Factory { get; set; }
        public Int16? MLSET_LineNumber { get; set; }
        public double? MLSET_PercTolerance { get; set; }
        public double? MLSET_PercProduction1 { get; set; }
        public double? MLSET_PercProduction2 { get; set; }
        #endregion Instance Properties
    }
}
