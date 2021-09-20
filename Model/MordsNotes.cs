using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsNotes : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? PurchOrdNoIssd { get; set; }
        public String Ntext { get; set; }
        #endregion Instance Properties

        public MordsNotes()
        {
            ID = 0;
            PurchOrdNoIssd = 0;
        }
    }
}
