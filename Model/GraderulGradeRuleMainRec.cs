using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GraderulGradeRuleMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int16? GrRGarmentType { get; set; }
        public Int32? GrRCustomer { get; set; }
        public Int16? GrRGradeOption { get; set; }
        public String GrRGradeOptionDescr { get; set; }
        public String GrRDescription { get; set; }


        private String grRSizeKey;
        public String GrRSizeKey
        {
            get { return grRSizeKey; }
            set 
            {
                grRSizeKey = value;
                OnPropertyChanged("GrRSizeKey");    
            }
        }

        public String GrRSize { get; set; }
        #endregion Instance Properties

        public GraderulGradeRuleMainRec()
        {
            ID = 0;
            GrRGradeOption = 0;
        }
    }
}
