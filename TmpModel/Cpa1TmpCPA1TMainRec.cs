using System;
using System.Linq;
using System.Text;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public class Cpa1TmpCPA1TMainRec : ViewModelBase, ICloneable<Cpa1TmpCPA1TMainRec>
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? CPA1TRecNo { get; set; }
        public Int32? CPA1TFileNo { get; set; }
        public Int16? CPA1TDelPoint { get; set; }
        public String CPA1TStyle { get; set; }
        public String CPA1TVarn { get; set; }
        public Int16? CPA1TCustNo { get; set; }
        public String CPA1TCustRef { get; set; }
        public DateTime? CPA1TDelDate { get; set; }
        public Int16? CPA1TAgntNo { get; set; }
        public Int32? CPA1TDockNo { get; set; }
        public Int16? CPA1TFactNo { get; set; }
        public DateTime? CPA1TDockDelDate { get; set; }
        public String CPA1TMainFabric { get; set; }
        public Int16? CPA1TOrderOuts { get; set; }
        public Int16? CPA1TInFileFlag { get; set; }

        public Cpa1TmpCPA1TMainRec()
        {
            CPA1TDockNo = 0;
            CPA1TFactNo = 0;
            CPA1TRecNo = 0;
        }
        public Cpa1TmpCPA1TMainRec Clone()
        {
            Cpa1TmpCPA1TMainRec MainRecClone = new Cpa1TmpCPA1TMainRec();
            
            MainRecClone.ID = ID;
            MainRecClone.CPA1TRecNo = CPA1TRecNo;
            MainRecClone.CPA1TFileNo = CPA1TFileNo;
            MainRecClone.CPA1TDelPoint = CPA1TDelPoint;
            MainRecClone.CPA1TStyle = CPA1TStyle;
            MainRecClone.CPA1TVarn = CPA1TVarn;
            MainRecClone.CPA1TCustNo = CPA1TCustNo;
            MainRecClone.CPA1TCustRef = CPA1TCustRef;
            MainRecClone.CPA1TDelDate = CPA1TDelDate;
            MainRecClone.CPA1TAgntNo = CPA1TAgntNo;
            MainRecClone.CPA1TDockNo = CPA1TDockNo;
            MainRecClone.CPA1TFactNo = CPA1TFactNo;
            MainRecClone.CPA1TDockDelDate = CPA1TDockDelDate;
            MainRecClone.CPA1TMainFabric = CPA1TMainFabric;
            MainRecClone.CPA1TOrderOuts = CPA1TOrderOuts;
            MainRecClone.CPA1TInFileFlag = CPA1TInFileFlag;

            return MainRecClone;
        }

        #endregion Instance Properties
    }
}
