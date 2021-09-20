using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CostdbCTMatsFFRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CostdbID { get; set; }
        public Int16? CTFFSpareFlag1 { get; set; }
        public Int16? CTFFSpareFlag2 { get; set; }
        public Int16? CTFFSpareFlag3 { get; set; }
        public Int16? CTFFSpareFlag4 { get; set; }
        public Int16? CTFFSpareFlag5 { get; set; }
        public Int16? CTFFSpareFlag6 { get; set; }
        public Int16? CTFFMatPart { get; set; }
        public String CTFFMatPartDescr { get; set; }
        public Int16? CTFFMatType { get; set; }
        public String CTFFMatTypeDescr { get; set; }
        public String CTFFMatCode { get; set; }
        public String CTFFMatDescription { get; set; }
        public Int16? CTFFMatColr { get; set; }
        public String CTFFMatColrDescr { get; set; }
        public Int16? CTFFMatColr1 { get; set; }
        public Int16? CTFFMatSupl { get; set; }
        public String CTFFMatSuplName { get; set; }
        public Int16? CTFFMatWhse { get; set; }
        public Int16? CTFFMatLocn { get; set; }
        public double? CTFFCosting { get; set; }
        public double? CTFFMatPrice { get; set; }
        public double? CTFFClothWidth { get; set; }
        public Int16? CTFFMatDutyFlag { get; set; }
        public String CTFFMatGrouping { get; set; }
        #endregion Instance Properties
    }
}
