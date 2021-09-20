using System;
using System.Linq;
using System.Text;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public class Cpa1TmpCPA1TMatsNotsRec : ViewModelBase, ICloneable<Cpa1TmpCPA1TMatsNotsRec>
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CPA1TMainRecID { get; set; }
        public Int16? CPA1TMaMatsNo { get; set; }
        public String CPA1TMaNotes { get; set; }

        #endregion Instance Properties

        public Cpa1TmpCPA1TMatsNotsRec Clone()
        {
            Cpa1TmpCPA1TMatsNotsRec MatsNotsRecClone = new Cpa1TmpCPA1TMatsNotsRec();

            MatsNotsRecClone.ID = ID;
            MatsNotsRecClone.CPA1TMainRecID = CPA1TMainRecID;
            MatsNotsRecClone.CPA1TMaMatsNo = CPA1TMaMatsNo;
            MatsNotsRecClone.CPA1TMaNotes = CPA1TMaNotes;

            return MatsNotsRecClone;
        }
    }
}
