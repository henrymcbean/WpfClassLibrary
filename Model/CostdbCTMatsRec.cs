using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class CostdbCTMatsRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32 CostdbID { get; set; }
        public Int32 Ordinal { get; set; } 
        public Int16? CTSpareFlag1 { get; set; }
        public Int16? CTSpareFlag2 { get; set; }
        public Int16? CTSpareFlag3 { get; set; }
        public Int16? CTSpareFlag4 { get; set; }
        public Int16? CTSpareFlag5 { get; set; }
        public Int16? CTSpareFlag6 { get; set; }

        private Int16? ctMatPart;
        public Int16? CTMatPart 
        {
            get { return ctMatPart; }
            set
            {
                ctMatPart = value;
                OnPropertyChanged("CTMatPart");
            }
        }


        private Int16? ctMatType;
        public Int16? CTMatType 
        {
            get { return ctMatType; }

            set
            {
                ctMatType = value;
                OnPropertyChanged("CTMatType");
            }
        }


        private String ctMatCode;
        public String CTMatCode 
        {
            get { return ctMatCode; }
            set
            {
                ctMatCode = value;
                OnPropertyChanged("CTMatCode");
            }
        }

        private Int16? ctMatColr;
        public Int16? CTMatColr 
        {
            get { return ctMatColr; }
            set
            {
                ctMatColr = value;
                OnPropertyChanged("CTMatColr");
            }
        }
        public Int16? CTMatColr1 { get; set; }

        private Int16? ctMatSupl;
        public Int16? CTMatSupl 
        {
            get { return ctMatSupl; }
            set
            {
                ctMatSupl = value;
                OnPropertyChanged("CTMatSupl");
            }
        }

        private Int16? ctMatWhse;
        public Int16? CTMatWhse 
        {
            get { return ctMatWhse; }
            set
            {
                ctMatWhse = value;
                OnPropertyChanged("CTMatWhse");
            }
        }

        private Int16? ctMatLocn;
        public Int16? CTMatLocn 
        {
            get { return ctMatLocn; }
            set
            {
                ctMatLocn = value;
                OnPropertyChanged("CTMatLocn");
            }
        }

        private double? ctCosting;
        public double? CTCosting
        {
            get { return ctCosting; }
            set
            {
                ctCosting = value;
                OnPropertyChanged("CTMatLocn");
            }
        }

        private double? ctMatPrice;
        public double? CTMatPrice 
        {
            get { return ctMatPrice; }
            set
            {
                ctMatPrice = value;
                OnPropertyChanged("CTMatPrice");
            }
        }
        public double? CTClothWidth { get; set; }

        private Int16? ctMatDutyFlag;
        public Int16? CTMatDutyFlag 
        {
            get { return ctMatDutyFlag; }
            set
            {
                ctMatDutyFlag = value;
                OnPropertyChanged("CTMatDutyFlag");
            }
        }
        public String CTMatGrouping { get; set; }
        #endregion Instance Properties

        // Grid Display Properties
        private string matPartDesc;
        public string MatPartDesc 
        {
            get { return matPartDesc; }
            set
            {
                matPartDesc = value;
                OnPropertyChanged("MatPartDesc");
            }
        }

        private string matTypeDesc;
        public string MatTypeDesc 
        {
            get { return matTypeDesc; }
            set
            {
                matTypeDesc = value;
                OnPropertyChanged("MatTypeDesc");
            }
        }

        private string matCodeDesc;
        public string MatCodeDesc 
        {
            get { return matCodeDesc; }
            set
            {
                matCodeDesc = value;
                OnPropertyChanged("MatCodeDesc");
            }
        }

        private string matColrDesc;
        public string MatColrDesc 
        {
            get { return matColrDesc; }
            set
            {
                matColrDesc = value;
                OnPropertyChanged("MatColrDesc");
            }
        }

        private string matSuplDesc;
        public string MatSuplDesc 
        {
            get { return matSuplDesc; }
            set
            {
                matSuplDesc = value;
                OnPropertyChanged("MatSuplDesc");
            }
        }

        private double? cost;
        public double? Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public bool ColourCombinationsA { get; set; }
        public bool CustomerPreferencesA { get; set; }
        public bool MatComsumtionA { get; set; }
        public bool MatPriceModifiedA { get; set; }
        public short CountryCode { get; set; }
        public short CurrcyNo { get; set; }

        public CostdbCTMatsRec()
        {
            CTSpareFlag1 = 0;
            CTSpareFlag2 = 0;
            CTSpareFlag3 = 0;
            CTSpareFlag4 = 0;
            CTSpareFlag5 = 0;
            CTSpareFlag6 = 0;
            //CTMatPart = 0;
            //CTMatType = 0;
            CTMatCode = "";
            //CTMatColr = 0;
            CTMatColr1 = 0;
            //CTMatSupl = 0;
            //CTMatWhse = 0;
            //CTMatLocn = 0;
            //CTCosting = 0;
            //CTMatPrice = 0;
            CurrcyNo = 0;
            CountryCode = 0;
            CTClothWidth = 0;
            CTMatDutyFlag = 0;
            CTMatGrouping = "";

            ColourCombinationsA = false;
            CustomerPreferencesA = false;
            MatComsumtionA = false;
            MatPriceModifiedA = false;
            ctMatDutyFlag = 0;
        }
    }
}
