using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmcopersGMCOperMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public String GMCStyle { get; set; }
        public String GMCVarn { get; set; }
        public String GMCStyleVarn { get; set; }

        private double? gmcCCostOfMake;
        public double? GMCCostOfMake 
        {
            get { return gmcCCostOfMake; }
            set
            {
                gmcCCostOfMake = value;
                OnPropertyChanged("GMCCostOfMake");
            }
        }

        private double? gmcPercentage;
        public double? GMCPercentage 
        {
            get { return gmcPercentage; }
            set
            {
                gmcPercentage = value;
                OnPropertyChanged("GMCPercentage");
            }
        }

        private double? gmcConvertionRate;
        public double? GMCConvertionRate 
        {
            get { return gmcConvertionRate; }
            set
            {
                gmcConvertionRate = value;
                OnPropertyChanged("GMCConvertionRate");
            }
        }
        #endregion Instance Properties

        private double? aim;
        public double? Aim
        {
            get { return aim; }
            set 
            {
                aim = value;
                OnPropertyChanged("Aim");
            }
        }

        public GmcopersGMCOperMRec()
        {
            ID = 0;
            gmcCCostOfMake = 0.0;
            gmcPercentage = 0.0;
            gmcConvertionRate = 0.0;
            aim = 0.0;
        }
    }
}
