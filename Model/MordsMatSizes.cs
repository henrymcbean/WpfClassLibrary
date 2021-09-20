using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsMatSizes : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? ItemsID { get; set; }
        public Int16? MatMinExpSz { get; set; }
        public Int16? MatMinUkSz { get; set; }
        public String MatExpSzKey { get; set; }
        public String MatUkSzKey { get; set; }
        public String MatSizesAmnt { get; set; }
        public String MatSizesAmntRecvd { get; set; }
        public String MatSizesPrice { get; set; }
        public String MatSizesPriceF { get; set; }
        #endregion Instance Properties

        public MordsMatSizes()
        {
            MatMinExpSz = 0;
            MatMinUkSz = 0;
            MatExpSzKey = "";
            MatSizesAmnt = "d,128,1,128,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,";
            MatSizesAmntRecvd = MatSizesAmntRecvd = MatSizesPrice = MatSizesPriceF;
        }
    }
}
