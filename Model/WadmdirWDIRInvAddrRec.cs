using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class WadmdirWDIRInvAddrRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32? WDIRIAClientType { get; set; }
        public Int32? WDIRIAClientNo { get; set; }


        private Int32? wDIRIAInvAddrNo;
        public Int32? WDIRIAInvAddrNo
        {
            get { return wDIRIAInvAddrNo; }
            set 
            {
                wDIRIAInvAddrNo = value;
                OnPropertyChanged("WDIRIAInvAddrNo");
            }
        }

        public String WDIRIAInvAddrCode { get; set; }
        public String WDIRIAClientName { get; set; }
        public Int32? WDIRIACountryCode { get; set; }


        private String wDIRIAAddressLine1;
        public String WDIRIAAddressLine1
        {
            get { return wDIRIAAddressLine1; }
            set 
            {
                wDIRIAAddressLine1 = value;
                OnPropertyChanged("WDIRIAAddressLine1");
            }
        }

        private String wDIRIAAddressLine2;
        public String WDIRIAAddressLine2
        {
            get { return wDIRIAAddressLine2; }
            set 
            {
                wDIRIAAddressLine2 = value;
                OnPropertyChanged("WDIRIAAddressLine2"); 
            }
        }

        private String wDIRIAAddressLine3;
        public String WDIRIAAddressLine3
        {
            get { return wDIRIAAddressLine3; }
            set 
            {
                wDIRIAAddressLine3 = value;
                OnPropertyChanged("WDIRIAAddressLine3"); 
            }
        }

        private String wDIRIAAddressLine4;
        public String WDIRIAAddressLine4
        {
            get { return wDIRIAAddressLine4; }
            set 
            {
                wDIRIAAddressLine4 = value;
                OnPropertyChanged("WDIRIAAddressLine4"); 
            }
        }

        private String wDIRIAAddressLine5;
        public String WDIRIAAddressLine5
        {
            get { return wDIRIAAddressLine5; }
            set 
            {
                wDIRIAAddressLine5 = value;
                OnPropertyChanged("WDIRIAAddressLine5"); 
            }
        }
        public String WDIRIAContact1 { get; set; }
        public String WDIRIAContact2 { get; set; }
        public String WDIRIAContact3 { get; set; }
        public String WDIRIAContact4 { get; set; }
        public String WDIRIAContact5 { get; set; }
        public String WDIRIATel1 { get; set; }
        public String WDIRIATel2 { get; set; }
        public String WDIRIATel3 { get; set; }
        public String WDIRIAFax1 { get; set; }
        public String WDIRIAFax2 { get; set; }
        public String WDIRIAFax3 { get; set; }
        public String WDIRIAInternet1 { get; set; }
        public String WDIRIAInternet2 { get; set; }
        public String WDIRIAInternet3 { get; set; }
        public String WDIRIAInternet4 { get; set; }
        public Int32? WDIRIAAgentNo { get; set; }
        public double? WDIRIAAgentCommision { get; set; }
        public Int32? WDIRIARepresentative { get; set; }
        public double? WDIRIARepresCommision { get; set; }
        public double? WDIRIADiscPer1 { get; set; }
        public Int32? WDIRIADays1 { get; set; }
        public double? WDIRIADiscPer2 { get; set; }
        public Int32? WDIRIADays2 { get; set; }
        public double? WDIRIADiscPer3 { get; set; }
        public Int32? WDIRIADays3 { get; set; }
        public double? WDIRIACreditLimit { get; set; }
        public double? WDIRIABalance { get; set; }
        public Int32? WDIRIACredibility { get; set; }
        public String WDIRIAVatRegNo { get; set; }
        public Int32? WDIRIAVatCode { get; set; }
        public Int32? WDIRIACurrency { get; set; }
        public String WDIRIARef1 { get; set; }
        public String WDIRIARef2 { get; set; }
        public String WDIRIARef3 { get; set; }
        #endregion Instance Properties
    }
}
