using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MstknotsMSTKNotesRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? NotesMRecID { get; set; }
        public String MSTKNText { get; set; }
        #endregion Instance Properties

        public MstknotsMSTKNotesRec()
        {
            ID = 0;
            NotesMRecID = 0;
            MSTKNText = "";
        }
    }
}
