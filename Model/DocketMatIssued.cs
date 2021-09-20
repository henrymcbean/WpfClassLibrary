using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class DocketMatIssued : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? DocketID { get; set; }
        public Int16? SpareFlag1 { get; set; }
        public Int16? SpareFlag2 { get; set; }
        public Int16? SpareFlag3 { get; set; }
        public Int16? MatPart { get; set; }
        public Int16? MatType { get; set; }
        public String MatCode { get; set; }
        public Int16? MatColr { get; set; }
        public Int16? MatColr1 { get; set; }
        public Int16? MatSupl { get; set; }
        public Int16? MatWhse { get; set; }
        public Int16? MatLocn { get; set; }
        public double? MatCosting { get; set; }
        public double? MatPrice { get; set; }
        public double? Required { get; set; }
        public String RequiredSizes { get; set; }
        public double? Supplied { get; set; }
        public String SuppliedSizes { get; set; }

        #endregion Instance Properties

        public DocketMatIssued()
        {
            ID = 0;

            SpareFlag1 =
            SpareFlag2 =
            SpareFlag3 =

            MatPart =
            MatType = 0;

            MatCode = "";

            MatColr =
            MatColr1 =
            MatSupl =
            MatWhse =
            MatLocn = 0;

            MatCosting =
            MatPrice =
            Required =
            Supplied = 0.0;
        }
    }
}
