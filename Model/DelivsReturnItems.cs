using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DelivsReturnItems
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? ReturnRecID { get; set; }
        public Int16? RetColr { get; set; }
        public Int16? RetColr1 { get; set; }
        public String RetQtys { get; set; }
        public Int16? RetWhse { get; set; }
        public Int16? RetLocn { get; set; }

        #endregion Instance Properties
    }
}
