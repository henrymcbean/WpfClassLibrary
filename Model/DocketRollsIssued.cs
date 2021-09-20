using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class DocketRollsIssued
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? ColrID { get; set; }
        public String DKBatchNo { get; set; }
        public Int32? DeliveryNo { get; set; }
        public Int32? RollNo { get; set; }
        public double? RollLength { get; set; }
        public double? RMatWidth { get; set; }
        public Int32? MakeableGars { get; set; }
        public Int32? DKTransNo { get; set; }
        public Int16? DKRollStatus1 { get; set; }
        public Int16? DKRollStatus2 { get; set; }
        #endregion Instance Properties
    }
}
