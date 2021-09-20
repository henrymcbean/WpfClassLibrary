using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MstknotsMSTKNotesMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? MSTKNMatType { get; set; }
        public String MSTKNMatCode { get; set; }
        public Int16? MSTKNMatColr { get; set; }
        public Int16? MSTKNMatColr1 { get; set; }
        public Int16? MSTKNMatSupl { get; set; }
        public Int16? MSTKNMatWhse { get; set; }
        public Int16? MSTKNMatLocn { get; set; }
        public String MSTKNIntraStat1 { get; set; }
        public String MSTKNIntraStat2 { get; set; }
        public String MSTKNMatConstru { get; set; }
        public String MSTKNMatSeason { get; set; }
        public Int32? MSTKNMatYearFrom { get; set; }
        public Int32? MSTKNMatYearTo { get; set; }
        #endregion Instance Properties

        public MstknotsMSTKNotesMRec()
        {
            ID = 0;
            MSTKNMatYearFrom = 0;
            MSTKNMatYearTo = 0;
            MSTKNIntraStat1 = "";
            MSTKNIntraStat2 = "";
            MSTKNMatConstru = "";
            MSTKNMatSeason = "";
        }
    }
}
