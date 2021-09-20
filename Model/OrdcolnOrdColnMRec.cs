using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdcolnOrdColnMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OCNColnNo { get; set; }
        public Int32? OCNColnNoOutsd { get; set; }
        public Int32? OCNColnNoCompl { get; set; }
        public String OCNStyle { get; set; }
        public String OCNVarn { get; set; }
        public String OCNExSzkey { get; set; }
        public String OCNUkSzkey { get; set; }
        public DateTime? OCNDelDate1 { get; set; }
        public DateTime? OCNDelDate2 { get; set; }
        public Int16? OCNDockFlag { get; set; }
        public Int16? OCNDelFlag { get; set; }

        #endregion Instance Properties

        public void Clear()
        {
            ID = 0;
            OCNColnNo = null;
            OCNColnNoOutsd = 0;
            OCNColnNoCompl = 0;

            OCNStyle = "";
            OCNVarn = "";
            OCNExSzkey = "";
            OCNUkSzkey = "";

            OCNDelDate1 = null;
            OCNDelDate2 = null;
            OCNDockFlag = 0;
            OCNDelFlag = 0;
        }
    }
}
