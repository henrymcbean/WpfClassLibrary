using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class WadmdirWDIRMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ClientID { get; set; }
        public Int32 WDIRClientType { get; set; }
        public Int32 WDIRClientNo { get; set; }
        public String WDIRClientCode { get; set; }
        public String WDIRClientName { get; set; }
        public Int32? WDIRCountryCode { get; set; }

        private String wDIRAddressLine1;
        public String WDIRAddressLine1
        {
            get { return wDIRAddressLine1; }
            set 
            {
                wDIRAddressLine1 = value;
                OnPropertyChanged("WDIRAddressLine1");
            }
        }

        private String wDIRAddressLine2;
        public String WDIRAddressLine2
        {
            get { return wDIRAddressLine2; }
            set 
            {
                wDIRAddressLine2 = value;
                OnPropertyChanged("WDIRAddressLine2");
            }
        }

        private String wDIRAddressLine3;
        public String WDIRAddressLine3
        {
            get { return wDIRAddressLine3; }
            set 
            {
                wDIRAddressLine3 = value;
                OnPropertyChanged("WDIRAddressLine3"); 
            }
        }

        private String wDIRAddressLine4;
        public String WDIRAddressLine4
        {
            get { return wDIRAddressLine4; }
            set 
            {
                wDIRAddressLine4 = value;
                OnPropertyChanged("WDIRAddressLine4");
            }
        }

        private String wDIRAddressLine5;
        public String WDIRAddressLine5
        {
            get { return wDIRAddressLine5; }
            set 
            {
                wDIRAddressLine5 = value;
                OnPropertyChanged("WDIRAddressLine5");
            }
        }

        public String WDIRContact1 { get; set; }
        public String WDIRContact2 { get; set; }
        public String WDIRContact3 { get; set; }
        public String WDIRContact4 { get; set; }
        public String WDIRContact5 { get; set; }

        private String wDIRTel1;
        public String WDIRTel1
        {
            get { return wDIRTel1; }
            set 
            {
                wDIRTel1 = value;
                OnPropertyChanged("WDIRTel1");
            }
        }

        private String wDIRTel2;
        public String WDIRTel2
        {
            get { return wDIRTel2; }
            set 
            {
                wDIRTel2 = value;
                OnPropertyChanged("WDIRTel2");
            }
        }

        private String wDIRTel3;
        public String WDIRTel3
        {
            get { return wDIRTel3; }
            set 
            {
                wDIRTel3 = value;
                OnPropertyChanged("WDIRTel3");
            }
        }

        public String WDIRFax1 { get; set; }
        public String WDIRFax2 { get; set; }
        public String WDIRFax3 { get; set; }
        public String WDIRInternet1 { get; set; }
        public String WDIRInternet2 { get; set; }
        public String WDIRInternet3 { get; set; }
        public String WDIRInternet4 { get; set; }

        private Int32? wDIRAgentNo;
        public Int32? WDIRAgentNo
        {
            get { return wDIRAgentNo; }
            set 
            {
                wDIRAgentNo = value;
                OnPropertyChanged("WDIRAgentNo");
            }
        }

        private double? wDIRAgentCommision;
        public double? WDIRAgentCommision
        {
            get { return wDIRAgentCommision; }
            set 
            {
                wDIRAgentCommision = value;
                OnPropertyChanged("WDIRAgentCommision");
            }
        }

        public Int32? WDIRepresentative { get; set; }
        public double? WDIRRepresCommision { get; set; }

        private double? wDIRDiscPer1;
        public double? WDIRDiscPer1
        {
            get { return wDIRDiscPer1; }
            set 
            {
                wDIRDiscPer1 = value;
                OnPropertyChanged("wDIRDiscPer1");
            }
        }

        public Int32? WDIRDays1 { get; set; }


        private double? wDIRDiscPer2;
        public double? WDIRDiscPer2
        {
            get { return wDIRDiscPer2; }
            set 
            {
                wDIRDiscPer2 = value;
                OnPropertyChanged("wDIRDiscPer2");
            }
        }

        public Int32? WDIRDays2 { get; set; }


        private double? wDIRDiscPer3;
        public double? WDIRDiscPer3
        {
            get { return wDIRDiscPer3; }
            set 
            {
                wDIRDiscPer3 = value;
                OnPropertyChanged("WDIRDiscPer3");
            }
        }

        public Int32? WDIRDays3 { get; set; }


        private double? wDIRCreditLimit;
        public double? WDIRCreditLimit
        {
            get { return wDIRCreditLimit; }
            set 
            {
                wDIRCreditLimit = value;
                OnPropertyChanged("WDIRCreditLimit"); 
            }
        }

        public double? WDIRBalance { get; set; }


        private Int32? wDIRCredibility;
        public Int32? WDIRCredibility
        {
            get { return wDIRCredibility; }
            set 
            {
                wDIRCredibility = value;
                OnPropertyChanged("WDIRCredibility");
            }
        }

        public String WDIRFlags { get; set; }
        public String WDIRCategories { get; set; }
        public String WDIRRef1 { get; set; }
        public String WDIRRef2 { get; set; }
        public String WDIRRef3 { get; set; }
        public Int32? WDIRPriorityPrices { get; set; }
        public Int32? WDIRPriorityDelivery { get; set; }
        public Int32? WDIRPriorityOther1 { get; set; }
        public Int32? WDIRPriorityOther2 { get; set; }
        public Int32? WDIRPriorityOther3 { get; set; }
        public Int32? WDIRPriorityOther4 { get; set; }
        public String WDIRVatRegNo { get; set; }
        public Int32? WDIRVatCode { get; set; }
        public Int32? WDIRCurrency { get; set; }
        public String WDIRNominals { get; set; }
        public String WDIRClasses { get; set; }
        #endregion Instance Properties
    }
}
