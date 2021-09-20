using System;
using System.Linq;
using System.Text;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public class Cpa1TmpCPA1TInstRec : ViewModelBase, ICloneable<Cpa1TmpCPA1TInstRec>
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CPA1TMainRecID { get; set; }
        public Int16? CPA1TInstNo { get; set; }
        public DateTime? CPA1TIsOrdDate { get; set; }
        public DateTime? CPA1TIsIssDate { get; set; }
        public Int16? CPA1TOperOutst { get; set; }

        #endregion Instance Properties

        public Cpa1TmpCPA1TInstRec Clone()
        {
            Cpa1TmpCPA1TInstRec InstRecClone = new Cpa1TmpCPA1TInstRec();

            InstRecClone.ID = ID;
            InstRecClone.CPA1TMainRecID = CPA1TMainRecID;
            InstRecClone.CPA1TInstNo = CPA1TInstNo;
            InstRecClone.CPA1TIsOrdDate = CPA1TIsOrdDate;
            InstRecClone.CPA1TIsIssDate = CPA1TIsIssDate;
            InstRecClone.CPA1TOperOutst = CPA1TOperOutst;

            return InstRecClone;
        }
    }
}
