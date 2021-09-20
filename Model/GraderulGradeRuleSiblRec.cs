using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GraderulGradeRuleSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? RuleMainRec { get; set; }

        public Int16 Ordinal { get; set; }

        private Int16? grGSpecSheetNo;
        public Int16? GrGSpecSheetNo
        {
            get { return grGSpecSheetNo; }
            set 
            {
                grGSpecSheetNo = value;
                OnPropertyChanged("GrGSpecSheetNo");   
            }
        }

        public Int16? GrGSpecCodeNo { get; set; }


        private double? grGGrade;
        public double? GrGGrade
        {
            get { return grGGrade; }
            set 
            {
                grGGrade = value;
                OnPropertyChanged("GrGGrade");  
            }
        }
        public String GrGGradeA { get; set; }
        #endregion Instance Properties

        private string specSheetNoDesc;
        public string SpecSheetNoDesc
        {
            get { return specSheetNoDesc; }
            set 
            {
                specSheetNoDesc = value;
                OnPropertyChanged("SpecSheetNoDesc");   
            }
        }

        public GraderulGradeRuleSiblRec()
        {
            ID = 0;
            RuleMainRec = 0;
            GrGSpecCodeNo = 0;
            GrGGradeA = "d,32,1,32";

            for (int i = 0; i < 32; i++)
                GrGGradeA += ",0";
        }
    }
}
