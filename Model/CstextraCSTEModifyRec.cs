using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CstextraCSTEModifyRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String CSTEMStyle { get; set; }
        public String CSTEMVarn { get; set; }
        public DateTime? CSTEMModifyDate { get; set; }

        private String cstemModifyName;
        public String CSTEMModifyName 
        {
            get { return cstemModifyName; }
            set
            {
                cstemModifyName = value;
                OnPropertyChanged("CSTEMModifyName");
            }
        }

        private String cstemModifyComments;
        public String CSTEMModifyComments 
        {
            get { return cstemModifyComments; }
            set
            {
                cstemModifyComments = value;
                OnPropertyChanged("CSTEMModifyComments");
            }
        }
        #endregion

        public CstextraCSTEModifyRec()
        {
            ID = 0;
            CSTEMModifyDate = DateTime.Now;
        }
    }
}
