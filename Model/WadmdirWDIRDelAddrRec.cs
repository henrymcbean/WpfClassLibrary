using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class WadmdirWDIRDelAddrRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int16? WDIRDAClientType { get; set; }

        private Int32? wDIRDAClientNo;
        public Int32? WDIRDAClientNo
        {
            get { return wDIRDAClientNo; }
            set 
            {
                wDIRDAClientNo = value;
                OnPropertyChanged("WDIRDAClientNo");  
            }
        }

        public Int32? WDIRDADelAddrNo { get; set; }
        public String WDIRDADelAddrCode { get; set; }
        public String WDIRDAClientName { get; set; }
        public Int16? WDIRDACountryCode { get; set; }

        private String wDIRDAAddressLine1;
        public String WDIRDAAddressLine1
        {
            get { return wDIRDAAddressLine1; }
            set 
            {
                wDIRDAAddressLine1 = value;
                OnPropertyChanged("WDIRDAAddressLine1"); 
            }
        }

        private String wDIRDAAddressLine2;
        public String WDIRDAAddressLine2
        {
            get { return wDIRDAAddressLine2; }
            set 
            {
                wDIRDAAddressLine2 = value;
                OnPropertyChanged("WDIRDAAddressLine2"); 
            }
        }

        private String wDIRDAAddressLine3;
        public String WDIRDAAddressLine3
        {
            get { return wDIRDAAddressLine3; }
            set 
            {
                wDIRDAAddressLine3 = value;
                OnPropertyChanged("WDIRDAAddressLine3"); 
            }
        }

        private String wDIRDAAddressLine4;
        public String WDIRDAAddressLine4
        {
            get { return wDIRDAAddressLine4; }
            set 
            {
                wDIRDAAddressLine4 = value;
                OnPropertyChanged("WDIRDAAddressLine4");  
            }
        }

        private String wDIRDAAddressLine5;
        public String WDIRDAAddressLine5
        {
            get { return wDIRDAAddressLine5; }
            set 
            {
                wDIRDAAddressLine5 = value;
                OnPropertyChanged("WDIRDAAddressLine5"); 
            }
        }

        public String WDIRDAContact1 { get; set; }
        public String WDIRDAContact2 { get; set; }
        public String WDIRDAContact3 { get; set; }
        public String WDIRDAContact4 { get; set; }
        public String WDIRDAContact5 { get; set; }
        public String WDIRDATel1 { get; set; }
        public String WDIRDATel2 { get; set; }
        public String WDIRDATel3 { get; set; }
        public String WDIRDAFax1 { get; set; }
        public String WDIRDAFax2 { get; set; }
        public String WDIRDAFax3 { get; set; }
        public String WDIRDAInternet1 { get; set; }
        public String WDIRDAInternet2 { get; set; }
        public String WDIRDAInternet3 { get; set; }
        public String WDIRDAInternet4 { get; set; }
        public Int32? WDIRDAAgentNo { get; set; }
        public double WDIRDAAgentCommision { get; set; }
        public Int32? WDIRDARepresentative { get; set; }
        public double? WDIRDARepresCommision { get; set; }
        public double? WDIRDADiscPer1 { get; set; }
        public Int16? WDIRDADays1 { get; set; }
        public double WDIRDADiscPer2 { get; set; }
        public Int16? WDIRDADays2 { get; set; }
        public double? WDIRDADiscPer3 { get; set; }
        public Int16? WDIRDADays3 { get; set; }
        public double? WDIRDACreditLimit { get; set; }
        public double? WDIRDABalance { get; set; }
        public Int16? WDIRDACredibility { get; set; }
        public String WDIRDAVatRegNo { get; set; }
        public Int16 WDIRDAVatCode { get; set; }
        public Int16? WDIRDACurrency { get; set; }
        public String WDIRDARef1 { get; set; }
        public String WDIRDARef2 { get; set; }
        public String WDIRDARef3 { get; set; }
        #endregion Instance Properties
    }
}
