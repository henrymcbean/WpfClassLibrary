using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbRMatSizes : XmlConvertor
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? RollsID { get; set; }
        public Int16? RMatMinExpSz { get; set; }
        public Int16? RMatMinUkSz { get; set; }
        public String RMatExpSzKey { get; set; }
        public String RMatUkSzKey { get; set; }
        public String RMatSizesAmnt { get; set; }
        public String RMatSizesOrdrd { get; set; }
        public String RMatSizesAlctd { get; set; }

        #endregion Instance Properties

        public RollsdbRMatSizes()
        {
            ID = RollsID = 0;

            RMatMinExpSz =
            RMatMinUkSz = 0;

            RMatExpSzKey =
            RMatUkSzKey = "";

            RMatSizesAmnt = "d,128,1,128,";
            for (int i = 0;i < 128;i++)
                RMatSizesAmnt += ",";

            RMatSizesOrdrd = RMatSizesAlctd = RMatSizesAmnt;
        }
    }
}
