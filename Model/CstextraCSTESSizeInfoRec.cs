using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CstextraCSTESSizeInfoRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String CSTESStyle { get; set; }
        public String CSTESVarn { get; set; }
        public String CSTESSizeKey { get; set; }
        public String CSTESSizeMin { get; set; }
        public String CSTESSizeMax { get; set; }
        #endregion Instance Properties

        public CstextraCSTESSizeInfoRec()
        {
            ID = 0;
        }
    }
}
