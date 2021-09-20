using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CusprefsCusPrefsSiblRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        private Int32? CusPrefsMRecID { get; set; }

        private Int16? cSPRFSELMatPart;
        public Int16? CSPRFSELMatPart
        {
            get { return cSPRFSELMatPart; }
            set 
            {
                cSPRFSELMatPart = value;
                OnPropertyChanged("CSPRFSELMatPart"); 
            }
        }

        private Int16? cSPRFSELMatType;
        public Int16? CSPRFSELMatType
        {
            get { return cSPRFSELMatType; }
            set 
            {
                cSPRFSELMatType = value;
                OnPropertyChanged("CSPRFSELMatType");  
            }
        }

        private String cSPRFSELMatCode;
        public String CSPRFSELMatCode
        {
            get { return cSPRFSELMatCode; }
            set 
            {
                cSPRFSELMatCode = value;
                OnPropertyChanged("CSPRFSELMatCode");   
            }
        }

        private Int16? cSPRFSELMatColr;
        public Int16? CSPRFSELMatColr
        {
            get { return cSPRFSELMatColr; }
            set 
            {
                cSPRFSELMatColr = value;
                OnPropertyChanged("CSPRFSELMatColr");    
            }
        }

        public Int16? CSPRFSELMatColr1 { get; set; }


        private Int16? cSPRFSELMatSupl;
        public Int16? CSPRFSELMatSupl
        {
            get { return cSPRFSELMatSupl; }
            set 
            {
                cSPRFSELMatSupl = value;
                OnPropertyChanged("CSPRFSELMatSupl");     
            }
        }

        private Int16? cSPRFSELMatWhse;
        public Int16? CSPRFSELMatWhse
        {
            get { return cSPRFSELMatWhse; }
            set 
            {
                cSPRFSELMatWhse = value;
                OnPropertyChanged("CSPRFSELMatWhse");    
            }
        }

        private Int16? cSPRFSELMatLocn;
        public Int16? CSPRFSELMatLocn
        {
            get { return cSPRFSELMatLocn; }
            set 
            {
                cSPRFSELMatLocn = value;
                OnPropertyChanged("CSPRFSELMatLocn");   
            }
        }

        private Int32? cSPRFSELCustNumber;
        public Int32? CSPRFSELCustNumber
        {
            get { return cSPRFSELCustNumber; }
            set 
            {
                cSPRFSELCustNumber = value;
                OnPropertyChanged("CSPRFSELCustNumber");    
            }
        }

        private Int32? cSPRFSELCustDelAddrs;
        public Int32? CSPRFSELCustDelAddrs
        {
            get { return cSPRFSELCustDelAddrs; }
            set 
            {
                cSPRFSELCustDelAddrs = value;
                OnPropertyChanged("CSPRFSELCustDelAddrs");     
            }
        }

        private double? cSPRFSELCosting;
        public double? CSPRFSELCosting
        {
            get { return cSPRFSELCosting; }
            set 
            {
                cSPRFSELCosting = value;
                OnPropertyChanged("CSPRFSELCosting");    
            }
        }

        private double? cSPRFSELPrice;
        public double? CSPRFSELPrice
        {
            get { return cSPRFSELPrice; }
            set 
            {
                cSPRFSELPrice = value;
                OnPropertyChanged("CSPRFSELPrice");     
            }
        }

        #endregion Instance Properties

        private String sELMatPartDesc;
        public String SELMatPartDesc
        {
            get { return sELMatPartDesc; }
            set 
            {
                sELMatPartDesc = value;
                OnPropertyChanged("SELMatPartDesc");  
            }
        }

        private String sELMatTypeDesc;
        public String SELMatTypeDesc
        {
            get { return sELMatTypeDesc; }
            set 
            {
                sELMatTypeDesc = value;
                OnPropertyChanged("SELMatTypeDesc");   
            }
        }

        private String sELMatCodeDesc;
        public String SELMatCodeDesc
        {
            get { return sELMatCodeDesc; }
            set 
            {
                sELMatCodeDesc = value;
                OnPropertyChanged("SELMatCodeDesc");    
            }
        }

        private String sELMatColrDesc;
        public String SELMatColrDesc
        {
            get { return sELMatColrDesc; }
            set 
            {
                sELMatColrDesc = value;
                OnPropertyChanged("SELMatColrDesc");    
            }
        }

        private String sELCustNumberDesc;
        public String SELCustNumberDesc
        {
            get { return sELCustNumberDesc; }
            set 
            {
                sELCustNumberDesc = value;
                OnPropertyChanged("SELCustNumberDesc");     
            }
        }

        private String sELCustDelAddrsDesc;
        public String SELCustDelAddrsDesc
        {
            get { return sELCustDelAddrsDesc; }
            set 
            {
                sELCustDelAddrsDesc = value;
                OnPropertyChanged("SELCustDelAddrsDesc");    
            }
        }

        public CusprefsCusPrefsSiblRec()
        {
            ID = 0;
            CusPrefsMRecID = 0;
        }

        public CusprefsCusPrefsSiblRec(CusprefsCusPrefsSiblRec CusPrefsSiblRec)
        {
            //ID = CusPrefsSiblRec.ID;
            //CusPrefsMRecID = CusPrefsSiblRec.CusPrefsMRecID;
            CSPRFSELMatPart = CusPrefsSiblRec.CSPRFSELMatPart;
            CSPRFSELMatType = CusPrefsSiblRec.CSPRFSELMatType;
            CSPRFSELMatCode = CusPrefsSiblRec.CSPRFSELMatCode;
            CSPRFSELMatColr = CusPrefsSiblRec.CSPRFSELMatColr;
            CSPRFSELMatColr1 = CusPrefsSiblRec.CSPRFSELMatColr1;
            CSPRFSELMatSupl = CusPrefsSiblRec.CSPRFSELMatSupl;
            CSPRFSELMatWhse = CusPrefsSiblRec.CSPRFSELMatWhse;
            CSPRFSELMatLocn = CusPrefsSiblRec.CSPRFSELMatLocn;
            CSPRFSELCustNumber = CusPrefsSiblRec.CSPRFSELCustNumber;
            CSPRFSELCustDelAddrs = CusPrefsSiblRec.CSPRFSELCustDelAddrs;
            CSPRFSELCosting = CusPrefsSiblRec.CSPRFSELCosting;
            CSPRFSELPrice = CusPrefsSiblRec.CSPRFSELPrice;
            SELMatPartDesc = CusPrefsSiblRec.SELMatPartDesc;
            SELMatTypeDesc = CusPrefsSiblRec.SELMatTypeDesc;
            SELMatCodeDesc = CusPrefsSiblRec.SELMatCodeDesc;
            SELMatColrDesc = CusPrefsSiblRec.SELMatColrDesc;
            SELCustNumberDesc = CusPrefsSiblRec.SELCustNumberDesc;
            SELCustDelAddrsDesc = CusPrefsSiblRec.SELCustDelAddrsDesc;
        }
    }
}
