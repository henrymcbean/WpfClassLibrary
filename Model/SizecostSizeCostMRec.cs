using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class SizecostSizeCostMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String SzCstStyle { get; set; }
        public String SzCstVariation { get; set; }
        public String SzCstSizeKey { get; set; }
        public Int16? SzCstColourNo { get; set; }
        public String SzCstCostPrices { get; set; }
        public String SzCstSellingPrices { get; set; }
        #endregion Instance Properties

        public SizecostSizeCostMRec()
        {
            ID = 0;
            SzCstCostPrices = "d,32,1,32";
            SzCstSellingPrices = "d,32,1,32";
        }
    }
}
