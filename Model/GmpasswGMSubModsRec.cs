using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmpasswGMSubModsRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? GMModsRec { get; set; }
        public Int16? GMSubModNo { get; set; }
        public Int16? GMSelFlag { get; set; }
        public String GMModFlags { get; set; }

        #endregion Instance Properties
    }
}
