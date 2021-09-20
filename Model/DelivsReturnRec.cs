using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DelivsReturnRec
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? DocketRecID { get; set; }
        public String ReturnNoteNo { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Int32? ReturnTime { get; set; }
        public Int32? REFileNumber { get; set; }
        public Int16? REDeliveryPoint { get; set; }
        public String REStyle { get; set; }
        public String REVarn { get; set; }
        public double? REDelCMTPrice { get; set; }
        public Int16? REDelMinExpSz { get; set; }
        public Int16? REDelMinUkSz { get; set; }
        public String REDelExpSzKey { get; set; }
        public String REDelUkSzKey { get; set; }

        #endregion Instance Properties
    }
}
