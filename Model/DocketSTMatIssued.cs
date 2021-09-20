using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DocketSTMatIssued
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? StyleID { get; set; }
        public Int16? STSpareFlag1 { get; set; }
        public Int16? STSpareFlag2 { get; set; }
        public Int16? STSpareFlag3 { get; set; }
        public Int16? STMatPart { get; set; }
        public Int16? STMatType { get; set; }
        public String STMatCode { get; set; }
        public Int16? STMatColr { get; set; }
        public Int16? STMatColr1 { get; set; }
        public Int16? STMatSupl { get; set; }
        public Int16? STMatWhse { get; set; }
        public Int16? STMatLocn { get; set; }
        public double? STMatCosting { get; set; }
        public double? STMatPrice { get; set; }
        public double? STRequired { get; set; }
        public double? STSupplied { get; set; }

        #endregion Instance Properties

        public DocketSTMatIssued()
        {
            STSpareFlag1 =
            STSpareFlag2 =
            STSpareFlag3 =

            STMatPart =
            STMatType = 0;

            STMatCode = "";

            STMatColr =
            STMatColr1 =
            STMatSupl =
            STMatWhse =
            STMatLocn = 0;

            STMatCosting =
            STMatPrice =
            STRequired =
            STSupplied = 0.0;
        }
    }
}
