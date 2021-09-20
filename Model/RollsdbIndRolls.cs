using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbIndRolls : XmlConvertor
    {
        #region Instance Properties
        public Int32? ItemID { get; set; }
        public Int32? RollsID { get; set; }
        public String RBatchNo { get; set; }
        public Int32? RDelivNo { get; set; }
        public Int32? RRollNo { get; set; }
        public double? RRollQty { get; set; }
        public double? RRollWidth { get; set; }
        public Int32? RTransNo { get; set; }
        public Int16? RRollStatus1 { get; set; }
        public Int16? RRollStatus2 { get; set; }
        #endregion Instance Properties

        public RollsdbIndRolls()
        {
            ItemID =
            RollsID = 0;

            RBatchNo = "";

            RDelivNo =
            RRollNo = 0;

            RRollQty = 
            RRollWidth = 0.0;

            RTransNo = 0;

            RRollStatus1 =
            RRollStatus2 = 0;
        }
    }
}
