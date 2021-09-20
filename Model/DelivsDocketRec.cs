using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class DelivsDocketRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32 DocketNo { get; set; }
        public Int16? JStyle { get; set; }
        public String Style { get; set; }
        public String Varn { get; set; }
        public Int16? FactoryNo { get; set; }
        public double? DelCMTPrice { get; set; }
        public Int16? DelMinExpSz { get; set; }
        public Int16? DelMinUkSz { get; set; }
        public String DelExpSzKey { get; set; }
        public String DelUkSzKey { get; set; }

        #endregion Instance Properties
    }
}
