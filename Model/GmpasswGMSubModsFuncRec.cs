using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmpasswGMSubModsFuncRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? GMSubModsRecID { get; set; }
        public Int16? GMSubModFuncNo { get; set; }
        public String GMFuncDescr { get; set; }
        public Int16? GMViewEnabled { get; set; }
        public Int16? GMSaveEnabled { get; set; }
        public Int16? GMPrintEnabled { get; set; }
        public Int16? GMPrivEnabled { get; set; }
        public Int16? GMOther1Enabled { get; set; }
        public Int16? GMOther2Enabled { get; set; }
        public Int16? GMOther3Enabled { get; set; }
        public Int16? GMOther4Enabled { get; set; }
        public Int16? GMOther5Enabled { get; set; }
        public Int16? GMOther6Enabled { get; set; }
        public String GMFuncComments { get; set; }

        #endregion Instance Properties
    }
}
