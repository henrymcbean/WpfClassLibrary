using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GopacksGOPKSMainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? GOPKSFileNo { get; set; }
        public Int16? GOPKSDelPoint { get; set; }
        public Int16? GOPKSDelIndex { get; set; }
        public String GOPKSStyle { get; set; }
        public String GOPKSVarn { get; set; }
        public Int16? GOPKSColrNo { get; set; }
        public Int16? GOPKSColourIndex { get; set; }

        #endregion Instance Properties
    }
}
