using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsMOPayments : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? PurchOrdNoIssd { get; set; }
        public String MOPInitials { get; set; }
        public DateTime? MOPDate { get; set; }
        public double? MOPAmount { get; set; }
        public Int16? MOPCurrency { get; set; }
        public double? MOPRate { get; set; }
        public Int16? MOPPayMethod { get; set; }
        public DateTime? MOPDatePay { get; set; }
        #endregion Instance Properties
    }
}
