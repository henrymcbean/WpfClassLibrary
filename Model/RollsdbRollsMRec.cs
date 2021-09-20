using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbRollsMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 RollsID { get; set; }
        public Int16? RMatType { get; set; }

        private String rMatCode;
        public String RMatCode 
        {
            get { return rMatCode; }
            set
            {
                rMatCode = value;
                OnPropertyChanged("RMatCode");
            }
        }


        private String rMatDescr;
        public String RMatDescr 
        {
            get { return rMatDescr; }
            set
            {
                rMatDescr = value;
                OnPropertyChanged("RMatDescr");
            }
        }

        private Int16? rMatColr;
        public Int16? RMatColr 
        {
            get { return rMatColr; }
            set
            {
                rMatColr = value;
                OnPropertyChanged("RMatColr");
            }
        }

        public Int16? RMatColr1 { get; set; }
        public Int16? RMatSupl { get; set; }
        public Int16? RMatWhse { get; set; }
        public Int16? RMatLocn { get; set; }
        public double? RMatCost { get; set; }
        public double? RMatCostF { get; set; }
        public String RMatUnit { get; set; }
        public Int32? RMatValueOrdUnit { get; set; }
        public String RMatSizeKey { get; set; }
        public double? RMatOrdered { get; set; }
        public double? RMatAllocated { get; set; }
        public double? RMatStockInTots { get; set; }
        public double? RMatStockInRolls { get; set; }

        #endregion Instance Properties

        private String smatColr;
        public String sMatColr
        {
            get { return smatColr; }
            set
            {
                smatColr = value;
                OnPropertyChanged("sMatColr");
            }
        }

        // Used to store Rollsdb.RMatSizes
        // Issued Sizes for SQL Server
        private String issueSizes;
        public String IssueSizes
        {
            get { return issueSizes; }
            set { issueSizes = value; }
        }

        public RollsdbRollsMRec()
        {
            RMatType = 0;

            RMatCode = 
            RMatDescr = 
            issueSizes = "";

            RMatColr =
            RMatColr1 =
            RMatSupl =
            RMatWhse =
            RMatLocn = 0;

            RMatCost =
            RMatCostF = 0.0;

            RMatUnit = "";

            RMatValueOrdUnit = 0;

            RMatSizeKey = "";

            RMatOrdered =
            RMatAllocated =
            RMatStockInTots =
            RMatStockInRolls = 0.0;
        }
    }
}
