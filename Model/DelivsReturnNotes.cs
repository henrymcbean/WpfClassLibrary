using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class DelivsReturnNotes
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? ReturnRecID { get; set; }
        public String Rettext { get; set; }

        #endregion Instance Properties
    }
}
