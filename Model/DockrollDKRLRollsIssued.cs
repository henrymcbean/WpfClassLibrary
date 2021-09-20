using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DockrollDKRLRollsIssued
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? DKRLMainDataID { get; set; }
        public String DKRLDKBatchNo { get; set; }
        public Int32? DKRLDeliveryNo { get; set; }
        public Int32? DKRLRollNo { get; set; }
        public double? DKRLRollLength { get; set; }
        public double? DKRLRMatWidth { get; set; }
        public Int32? DKRLMakeableGars { get; set; }
        public Int32? DKRLDKTransNo { get; set; }
        public Int16? DKRLDKRollStatus1 { get; set; }
        public Int16? DKRLDKRollStatus2 { get; set; }
        public Int16? DKRLDKSelectFlag { get; set; }

        #endregion Instance Properties
    }
}
