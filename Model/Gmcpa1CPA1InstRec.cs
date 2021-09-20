using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class Gmcpa1CPA1InstRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CPA1MainRecID { get; set; }
        public Int16? CPA1InstNo { get; set; }
        public DateTime? CPA1IsOrdDate { get; set; }
        public DateTime? CPA1IsIssDate { get; set; }
        public Int16? CPA1OperOutst { get; set; }

        #endregion Instance Properties
    }
}
