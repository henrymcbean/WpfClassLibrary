using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class SzgridGMSZGSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MainRecID { get; set; }
        public Int16? Ordinal { get; set; }
        public Int16? GMSZGPartNo { get; set; }
        public Int16? GMSZGCodeNo { get; set; }
        public String GMSZGMeasure { get; set; }
        public double? GMSZGTolerance { get; set; }
        #endregion Instance Properties

        public SzgridGMSZGSiblRec()
        {
            ID = 0;
            MainRecID = 0;
        }
    }
}
