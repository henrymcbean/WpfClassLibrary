using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class PricelstXPLNotesRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? XPLMainRecID { get; set; }

        private String xplNotesRec;
        public String XPLNotesRec 
        {
            get { return xplNotesRec; }
            set
            {
                xplNotesRec = value;
                OnPropertyChanged("XPLNotesRec");
            }
        }
        #endregion Instance Properties

        public PricelstXPLNotesRec()
        {
            ID = 0;
            XPLMainRecID = 0;
        }
    }
}
