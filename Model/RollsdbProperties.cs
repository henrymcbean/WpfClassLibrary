using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class RollsdbProperties : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? RollsID { get; set; }
        public String SuplQuality { get; set; }
        public String SuplColour { get; set; }

        private String suplDescr;
        public String SuplDescr 
        {
            get { return suplDescr; }
            set
            {
                suplDescr = value;
                OnPropertyChanged("SuplDescr");
            }
        }

        private double? matWidth1;
        public double? MatWidth1 
        {
            get { return matWidth1; }
            set
            {
                matWidth1 = value;
                OnPropertyChanged("MatWidth1");
            }
        }

        private double? matWidth2;
        public double? MatWidth2
        {
            get { return matWidth2; }
            set
            {
                matWidth2 = value;
                OnPropertyChanged("MatWidth2");
            }
        }

        private double? matWeight1;
        public double? MatWeight1 
        {
            get { return matWeight1; }
            set
            {
                matWeight1 = value;
                OnPropertyChanged("MatWeight1");
            }
        }

        private double? matWeight2;
        public double? MatWeight2
        {
            get { return matWeight2; }
            set
            {
                matWeight2 = value;
                OnPropertyChanged("MatWeight2");
            }
        }
        public String MatCompositionNo { get; set; }
        public String MatCompositionPer { get; set; }

        private Int32? matOrgCountry;
        public Int32? MatOrgCountry 
        {
            get { return matOrgCountry; }
            set
            {
                matOrgCountry = value;
                OnPropertyChanged("MatOrgCountry");
            }
        }

        private double? currencyRate;
        public double? CurrencyRate 
        {
            get { return currencyRate; }
            set
            {
                currencyRate = value;
                OnPropertyChanged("CurrencyRate");
            }
        }

        private double? orderUnit;
        public double? OrderUnit 
        {
            get { return orderUnit; }
            set
            {
                orderUnit = value;
                OnPropertyChanged("OrderUnit");
            }
        }

        private double? minOrderQty;
        public double? MinOrderQty 
        {
            get { return minOrderQty; }
            set
            {
                minOrderQty = value;
                OnPropertyChanged("MinOrderQty");
            }
        }

        private Int32? leadTime;
        public Int32? LeadTime 
        {
            get { return leadTime; }
            set
            {
                leadTime = value;
                OnPropertyChanged("LeadTime");
            }
        }

        private double? reOrderLevel;
        public double? ReOrderLevel 
        {
            get { return reOrderLevel; }
            set
            {
                reOrderLevel = value;
                OnPropertyChanged("ReOrderLevel");
            }
        }

        private double? matMinDeliveryCharge;
        public double? MatMinDeliveryCharge 
        {
            get { return matMinDeliveryCharge; }
            set
            {
                matMinDeliveryCharge = value;
                OnPropertyChanged("MatMinDeliveryCharge");
            }
        }

        private String matMeasure;
        public String MatMeasure 
        {
            get { return matMeasure; }
            set
            {
                matMeasure = value;
                OnPropertyChanged("MatMeasure");
            }
        }

        private double? matMinOrderCharge;
        public double? MatMinOrderCharge 
        {
            get { return matMinOrderCharge; }
            set
            {
                matMinOrderCharge = value;
                OnPropertyChanged("MatMinOrderCharge");
            }
        }


        private double? matRoundOrderValue;
        public double? MatRoundOrderValue 
        {
            get { return matRoundOrderValue; }
            set
            {
                matRoundOrderValue = value;
                OnPropertyChanged("MatRoundOrderValue");
            }
        }

        private String careInsts;
        public String CareInsts 
        {
            get { return careInsts; }
            set
            {
                careInsts = value;
                OnPropertyChanged("CareInsts");
            }
        }

        private String comments;
        public String Comments 
        {
            get { return comments; }
            set 
            {
                comments = value;
                OnPropertyChanged("Comments");
            } 
        }
        #endregion Instance Properties

        // *********************************************

        private short[] compositionNo;
        public short[] CompositionNo
        {
            get { return compositionNo; }
            set 
            {
                compositionNo = value;
                OnPropertyChanged("CompositionNo");
            }
        }

        private String[] compositionNoDesc;
        public String[] CompositionNoDesc
        {
            get { return compositionNoDesc; }
            set
            {
                compositionNoDesc = value;
                OnPropertyChanged("CompositionNoDesc");
            }
        }

        private double[] compositionPer;
        public double[] CompositionPer
        {
            get { return compositionPer; }
            set 
            {
                compositionPer = value;
                OnPropertyChanged("CompositionPer");
            }
        }

        private String orgCountry;
        public String OrgCountry
        {
            get { return orgCountry; }
            set
            {
                orgCountry = value;
                OnPropertyChanged("OrgCountry");
            }
        }

        private double ndPcent;
        public double Percent
        {
            get { return ndPcent; }
            set
            {
                ndPcent = value;
                OnPropertyChanged("Percent");
            }
        }

        public RollsdbProperties()
        {
            ID = RollsID = 0;
            ndPcent = 0.0;

            SuplQuality = 
            SuplColour = 
            SuplDescr = "";

            MatWidth1 =
            MatWidth2 =
            MatWeight1 =
            MatWeight2 = 0.0;

            MatCompositionNo = "s,6,1,6,0,0,0,0,0,0";
            MatCompositionPer = "d,6,1,6,0,0,0,0,0,0";

            MatOrgCountry = 0;

            CurrencyRate =
            OrderUnit =
            MinOrderQty = 0.0;

            LeadTime = 0;
            ReOrderLevel = 0.0;

            MatMeasure = "";

            MatMinDeliveryCharge =
            MatMinOrderCharge =
            MatRoundOrderValue = 0.0;

            CareInsts = "";           // [3][62];

            Comments = "";            // [2][62];
            compositionNoDesc = new String[6];
            compositionPer = new double[6];
            compositionNo = new short[6];
        }
    }
}
