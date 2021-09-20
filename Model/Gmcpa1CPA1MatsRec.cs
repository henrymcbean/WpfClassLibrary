using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class Gmcpa1CPA1MatsRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CPA1MainRecID { get; set; }
        public Int16? CPA1MatsNo { get; set; }
        public DateTime? CPA1MaOrdDate { get; set; }
        public DateTime? CPA1MaIssDate { get; set; }
        public Int32? CPA1MaOrdNo { get; set; }
        public Int16? CPA1MatsOutst { get; set; }

        #endregion Instance Properties
    }
}
