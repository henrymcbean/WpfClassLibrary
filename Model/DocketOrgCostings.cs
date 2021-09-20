using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class DocketOrgCostings : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ColrID { get; set; }

        private Int16? orgSpareFlag1;
        public Int16? OrgSpareFlag1 
        {
            get { return orgSpareFlag1; }
            set
            {
                orgSpareFlag1 = value;
                OnPropertyChanged("OrgSpareFlag1");   
            } 
        }

        public Int16? OrgSpareFlag2 { get; set; }
        public Int16? OrgSpareFlag3 { get; set; }
        public Int16? OrgMatPart { get; set; }
        public Int16? OrgMatType { get; set; }
        public String OrgMatCode { get; set; }
        public Int16? OrgMatColr { get; set; }
        public Int16? OrgMatColr1 { get; set; }
        public Int16? OrgMatSupl { get; set; }
        public Int16? OrgMatWhse { get; set; }
        public Int16? OrgMatLocn { get; set; }
        public double? OrgCosting { get; set; }
        public double? OrgMatPrice { get; set; }
        #endregion Instance Properties

        public String OrgMatPartDesc { get; set; }
        public String OrgMatTypeDesc { get; set; }
        public String OrgMatCodeDesc { get; set; }
        public String OrgMatColrDesc { get; set; }
        public String OrgMatSuplDesc { get; set; }
        public double? Cost { get; set; }

        public DocketOrgCostings()
        {
            ID = 0;

            OrgSpareFlag1 =
            OrgSpareFlag2 =
            OrgSpareFlag3 =
            OrgMatPart =
            OrgMatType = 0;

            OrgMatColr =
            OrgMatColr1 =
            OrgMatSupl =
            OrgMatWhse =
            OrgMatLocn = 0;

            OrgCosting =
            OrgMatPrice = 0.0;
        }
    }
}
