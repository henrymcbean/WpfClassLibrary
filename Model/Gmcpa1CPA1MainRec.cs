using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class Gmcpa1CPA1MainRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CPA1FileNo { get; set; }
        public Int16? CPA1DelPoint { get; set; }
        public String CPA1Style { get; set; }
        public String CPA1Varn { get; set; }
        public Int16? CPA1CustNo { get; set; }
        public String CPA1CustRef { get; set; }
        public DateTime? CPA1DelDate { get; set; }
        public DateTime? CPA1DelDateRev { get; set; }
        public Int16? CPA1AgntNo { get; set; }
        public Int32? CPA1DockNo { get; set; }
        public Int16? CPA1FactNo { get; set; }
        public DateTime? CPA1DockDelDate { get; set; }
        public DateTime? CPA1DockDelDateRev { get; set; }
        public String CPA1MainFabric { get; set; }
        public Int16? CPA1OrderOuts { get; set; }
        public Int16? CAP1DeletionFlag { get; set; }

        #endregion Instance Properties
    }
}
