using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbRMatSizesE : XmlConvertor
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? RollsID { get; set; }
        public String RMatSizesPrice { get; set; }
        public String RMatSizesPriceF { get; set; }
        #endregion Instance Properties

        public RollsdbRMatSizesE()
        {
            ID =
            RollsID = 0;

            RMatSizesPrice = "d,128,1,128,";
            for (int i = 0;i < 128;i++)
                RMatSizesPrice += ",";

            RMatSizesPriceF = RMatSizesPrice;
        }
    }
}
