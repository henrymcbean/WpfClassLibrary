using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class DocketColrsQtys : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? StyleID { get; set; }
        public Int16? ColourNo { get; set; }
        public Int16? ColourNo1 { get; set; }
        public String DKTLineNo { get; set; }
        public String Ratios { get; set; }
        public String IssdQtys { get; set; }
        public String RecvQtys { get; set; }
        public double? MatCost { get; set; }
        #endregion Instance Properties

        public DocketColrsQtys()
        {
            ColourNo =
            ColourNo1 = 0;

            Ratios =
            IssdQtys =
            RecvQtys =
            DKTLineNo = "";

            MatCost = 0.0;
        }
    }
}
