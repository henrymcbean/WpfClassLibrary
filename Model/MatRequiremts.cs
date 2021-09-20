using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class ColoursInfo
    {
        private string ukSizeKey;
        public string UkSizeKey
        {
            get { return ukSizeKey; }
            set { ukSizeKey = value; }
        }

        private string exSizeKey;
        public string ExSizeKey
        {
            get { return exSizeKey; }
            set { exSizeKey = value; }
        }

        long[] colourTotals; // [24];
        public long[] ColourTotals
        {
            get { return colourTotals; }
            set { colourTotals = value; }
        }

        public ColoursInfo()
        {
            UkSizeKey = "";
            ExSizeKey = "";
            colourTotals = new long[24];
        }
    }
    public class MatRequiremts : ViewModelBase
    {
        private short? spareFlag1;
        public short? SpareFlag1
        {
            get { return spareFlag1; }
            set { spareFlag1 = value; }
        }

        private short matPart;
        public short MatPart
        {
            get { return matPart; }
            set { matPart = value; }
        }

        private string matPartDesc;   // [50]
        public string MatPartDesc
        {
            get { return matPartDesc; }
            set { matPartDesc = value; }
        }

        private short matType;
        public short MatType
        {
            get { return matType; }
            set { matType = value; }
        }

        private string matTypeDesc;   // [50]
        public string MatTypeDesc
        {
            get { return matTypeDesc; }
            set { matTypeDesc = value; }
        }

        private string matCode;       // [26]
        public string MatCode
        {
            get { return matCode; }
            set { matCode = value; }
        }

        private short matColr;
        public short MatColr
        {
            get { return matColr; }
            set { matColr = value; }
        }

        private short matColr1;
        public short MatColr1
        {
            get { return matColr1; }
            set { matColr1 = value; }
        }

        private string matColrDesc;   // [50]
        public string MatColrDesc
        {
            get { return matColrDesc; }
            set { matColrDesc = value; }
        }

        private short matSupl;
        public short MatSupl
        {
            get { return matSupl; }
            set 
            {
                matSupl = value;
                OnPropertyChanged("MatSupl"); 
            }
        }

        private string matSuplDesc;
        public string MatSuplDesc
        {
            get { return matSuplDesc; }
            set { matSuplDesc = value; }
        }

        private short matWhse;
        public short MatWhse
        {
            get { return matWhse; }
            set 
            {
                matWhse = value;
                OnPropertyChanged("MatWhse");  
            }
        }

        private short matLocn;
        public short MatLocn
        {
            get { return matLocn; }
            set { matLocn = value; }
        }

        private double matCosting;
        public double MatCosting
        {
            get { return matCosting; }
            set { matCosting = value; }
        }

        private double matPrice;
        public double MatPrice
        {
            get { return matPrice; }
            set { matPrice = value; }
        }

        private double? stock;			// Free
        public double? Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private double[] stockSizes;	// Free Sizes [128]
        public double[] StockSizes
        {
            get { return stockSizes; }
            set { stockSizes = value; }
        }

        private double required;
        public double Required
        {
            get { return required; }
            set { required = value; }
        }

        private double[] requiredSizes; // [128]
        public double[] RequiredSizes
        {
            get { return requiredSizes; }
            set { requiredSizes = value; }
        }

        private double? supplied;
        public double? Supplied
        {
            get { return supplied; }
            set { supplied = value; }
        }

        private double[] suppliedSizes;   // [128]
        public double[] SuppliedSizes
        {
            get { return suppliedSizes; }
            set { suppliedSizes = value; }
        }

        private double? issue;
        public double? Issue
        {
            get { return issue; }
            set { issue = value; }
        }

        private double[] issueSizes;      // [128]
        public double[] IssueSizes
        {
            get { return issueSizes; }
            set { issueSizes = value; }
        }

        private double? outstanding;
        public double? Outstanding
        {
            get { return outstanding; }
            set { outstanding = value; }
        }

        private short iOtherStock;
        public short IOtherStock
        {
            get { return iOtherStock; }
            set { iOtherStock = value; }
        }

        private short iMatReturnWhse;
        public short IMatReturnWhse
        {
            get { return iMatReturnWhse; }
            set { iMatReturnWhse = value; }
        }

        private short iMatReturnLocn;
        public short IMatReturnLocn
        {
            get { return iMatReturnLocn; }
            set { iMatReturnLocn = value; }
        }

        private double dblMatReturnPrice;
        public double DblMatReturnPrice
        {
            get { return dblMatReturnPrice; }
            set { dblMatReturnPrice = value; }
        }

        private short iFileMultiWhseLocn;
        public short IFileMultiWhseLocn
        {
            get { return iFileMultiWhseLocn; }
            set { iFileMultiWhseLocn = value; }
        }

        private short iWhseLocnGeaterThenTwo;
        public short IWhseLocnGeaterThenTwo
        {
            get { return iWhseLocnGeaterThenTwo; }
            set { iWhseLocnGeaterThenTwo = value; }
        }

        private double? dockMatAllocated;
        public double? DockMatAllocated
        {
            get { return dockMatAllocated; }
            set { dockMatAllocated = value; }
        }

        private double[] dockMatAllocatedSizes;
        public double[] DockMatAllocatedSizes
        {
            get { return dockMatAllocatedSizes; }
            set { dockMatAllocatedSizes = value; }
        }

        private double? toSupply;
        public double? ToSupply
        {
            get { return toSupply; }
            set 
            {
                toSupply = value;
                OnPropertyChanged("ToSupply");   
            }
        }

        private short? matSizeKey;
        public short? MatSizeKey
        {
            get { return matSizeKey; }
            set { matSizeKey = value; }
        }

        public MatRequiremts()
        {
            stock = 0;
            Supplied = 0.0;
            stockSizes = new double[128];
            issueSizes = new double[128];
            requiredSizes = new double[128];
            suppliedSizes = new double[128];
            dockMatAllocatedSizes = new double[128];

            for (int i = 0;i < 128;i++)
            {
                stockSizes[i] = issueSizes[i] =
                requiredSizes[i] = suppliedSizes[i] =
                dockMatAllocatedSizes[i] = 0.0;
            }
        }
    }
}
