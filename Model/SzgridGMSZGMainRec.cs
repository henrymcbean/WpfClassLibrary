using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class SzgridGMSZGMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String GMSZGStyle { get; set; }
        public String GMSZGVarn { get; set; }
        public Int16? GMSZStType { get; set; }
        public String GMSZGSizeKey { get; set; }
        public Int16? GMSZGType { get; set; }
        public Int16? GMSZCust { get; set; }
        public double? GMSZPercBasic { get; set; }
        public double? GMSZRoundFact { get; set; }
        #endregion Instance Properties

        public SzgridGMSZGMainRec()
        {
            ID = 0;
            GMSZGSizeKey = "";
        }
    }
}
