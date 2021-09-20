using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GinvoiceINVStyleRec
    {
        #region Instance Properties
        public Int32? INVStyleID { get; set; }
        public Int32? INVInvoiceNo { get; set; }
        public Int32? INVFileNo { get; set; }
        public String INVOrderRef { get; set; }
        public Int16? INVDelPoint { get; set; }
        public String INVStyle { get; set; }
        public String INVVarn { get; set; }
        public String INVExSzKey { get; set; }
        public String INVUkSzKey { get; set; }
        public Int16? INVVatNo { get; set; }
        public double? INVVatRate { get; set; }
        public Int16? INVNominal { get; set; }
        public double? INVLineDisc1 { get; set; }
        public double? INVLineDisc2 { get; set; }
        public double? INVLineDisc3 { get; set; }
        public String INVDepartment { get; set; }
        #endregion Instance Propertie
    }
}
