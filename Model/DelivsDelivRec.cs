using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class DelivsDelivRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? DocketRecID { get; set; }
        public String DelivNoteNo { get; set; }
        public DateTime? DelivDate { get; set; }
        public DateTime? DelivTime { get; set; }
        public Int32? DEFileNumber { get; set; }
        public Int16? DEDeliveryPoint { get; set; }
        public String DEStyle { get; set; }
        public String DEVarn { get; set; }
        public double? DEDelCMTPrice { get; set; }
        public Int16? DEDelMinExpSz { get; set; }
        public Int16? DEDelMinUkSz { get; set; }
        public String DEDelExpSzKey { get; set; }
        public String DEDelUkSzKey { get; set; }

        #endregion Instance Properties

        public DelivsDelivRec()
        {
            ID = 0;
            DocketRecID = 0;
        }
    }
}
