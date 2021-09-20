using System;
using System.Linq;
using System.Text;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public class Cpa1TmpCPA1TMatsRec : ViewModelBase, ICloneable<Cpa1TmpCPA1TMatsRec>
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CPA1TMainRecID { get; set; }
        public Int16? CPA1TMatsNo { get; set; }
        public DateTime? CPA1TMaOrdDate { get; set; }
        public DateTime? CPA1TMaIssDate { get; set; }
        public Int32? CPA1TMaOrdNo { get; set; }
        public Int16? CPA1TMatsOutst { get; set; }

        #endregion Instance Properties

        public Cpa1TmpCPA1TMatsRec Clone()
        {
            Cpa1TmpCPA1TMatsRec MatsRecClone = new Cpa1TmpCPA1TMatsRec();

            MatsRecClone.ID = ID;
            MatsRecClone.CPA1TMainRecID = CPA1TMainRecID;
            MatsRecClone.CPA1TMatsNo = CPA1TMatsNo;
            MatsRecClone.CPA1TMaOrdDate = CPA1TMaOrdDate;
            MatsRecClone.CPA1TMaIssDate = CPA1TMaIssDate;
            MatsRecClone.CPA1TMaOrdNo = CPA1TMaOrdNo;
            MatsRecClone.CPA1TMatsOutst = CPA1TMatsOutst;

            return MatsRecClone;
        }
    }
}
