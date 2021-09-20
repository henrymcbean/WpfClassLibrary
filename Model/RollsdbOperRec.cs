using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbOperRec : XmlConvertor
    {
        #region Instance Properties
        public Int32? ItemID { get; set; }
        public Int32? RollsID { get; set; }
        public Int32? OperNo { get; set; }
        #endregion Instance Properties
    }
}
