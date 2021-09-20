using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbProcRec : XmlConvertor
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? RollsID { get; set; }
        public Int32? OperNo { get; set; }
        public Int32? ProcNo { get; set; }
        public Int32? ProcSel { get; set; }
        #endregion Instance Properties
    }
}
