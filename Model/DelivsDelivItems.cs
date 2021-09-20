using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DelivsDelivItems : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? DelivRecID { get; set; }
        public Int16? Colr { get; set; }
        public Int16? Colr1 { get; set; }
        public String Qtys { get; set; }
        public Int16? Whse { get; set; }
        public Int16? Locn { get; set; }
        #endregion Instance Properties

        public DelivsDelivItems()
        {
            ID = 0;
        }
    }
}
