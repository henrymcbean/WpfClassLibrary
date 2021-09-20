using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class SzgridGMSZGNotsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? MainRecID { get; set; }
        public String GMSZGNotes { get; set; }

        #endregion Instance Properties

        public SzgridGMSZGNotsRec()
        {
            ID = 0;
            MainRecID = 0;
        }
    }
}
