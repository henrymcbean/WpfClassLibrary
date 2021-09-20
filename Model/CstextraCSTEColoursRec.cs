using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CstextraCSTEColoursRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String CSTECStyle { get; set; }
        public String CSTECVarn { get; set; }
        public Int16? CSTECColourIndex { get; set; }
        public Int16? CSTECColourNo { get; set; }
        #endregion Instance Properties

        public CstextraCSTEColoursRec()
        {
            ID = 0;
        }
    }
}
