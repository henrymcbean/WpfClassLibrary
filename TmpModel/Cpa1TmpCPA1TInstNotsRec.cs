using System;
using System.Linq;
using System.Text;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public class Cpa1TmpCPA1TInstNotsRec : ViewModelBase, ICloneable<Cpa1TmpCPA1TInstNotsRec>
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CPA1TMainRecID { get; set; }
        public Int16? CPA1TIsInstNo { get; set; }
        public String CPA1TIsNotes { get; set; }

        #endregion Instance Properties

        public Cpa1TmpCPA1TInstNotsRec Clone()
        {
            Cpa1TmpCPA1TInstNotsRec InstNotsRecClone = new Cpa1TmpCPA1TInstNotsRec();

            InstNotsRecClone.ID = ID;
            InstNotsRecClone.CPA1TMainRecID = CPA1TMainRecID;
            InstNotsRecClone.CPA1TIsInstNo = CPA1TIsInstNo;
            InstNotsRecClone.CPA1TIsNotes = CPA1TIsNotes;

            return InstNotsRecClone;
        }
    }
}
