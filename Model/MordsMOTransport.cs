using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class MordsMOTransport : ViewModelBase
    {
        #region Instance Properties
        private Int32? iD;
        public Int32? ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private Int32? purchOrdNoIssd;
        public Int32? PurchOrdNoIssd
        {
            get { return purchOrdNoIssd; }
            set 
            {
                purchOrdNoIssd = value;
                OnPropertyChanged("PurchOrdNoIssd");
            }
        }

        private Int32? mOAgentNo;
        public Int32? MOAgentNo
        {
            get { return mOAgentNo; }
            set 
            {
                mOAgentNo = value;
                OnPropertyChanged("MOAgentNo");
            }
        }

        private double? mOAgentCommn;
        public double? MOAgentCommn
        {
            get { return mOAgentCommn; }
            set 
            {
                mOAgentCommn = value;
                OnPropertyChanged("MOAgentCommn");
            }
        }

        private String mOTerms;
        public String MOTerms
        {
            get { return mOTerms; }
            set 
            {
                mOTerms = value;
                OnPropertyChanged("MOTerms");
            }
        }

        private Int32? mOTransporter;
        public Int32? MOTransporter
        {
            get { return mOTransporter; }
            set 
            {
                mOTransporter = value;
                OnPropertyChanged("MOTransporter");
            }
        }

        private Int16? mOTranspMethod;
        public Int16? MOTranspMethod
        {
            get { return mOTranspMethod; }
            set 
            {
                mOTranspMethod = value;
                OnPropertyChanged("MOTranspMethod");
            }
        }

        private Int16? mOPackingMethod;
        public Int16? MOPackingMethod
        {
            get { return mOPackingMethod; }
            set 
            {
                mOPackingMethod = value;
                OnPropertyChanged("MOPackingMethod");
            }
        }

        private String mOConsignment;
        public String MOConsignment
        {
            get { return mOConsignment; }
            set 
            {
                mOConsignment = value;
                OnPropertyChanged("MOConsignment");
            }
        }

        private String mODelConditions;
        public String MODelConditions
        {
            get { return mODelConditions; }
            set 
            {
                mODelConditions = value;
                OnPropertyChanged("MODelConditions");
            }
        }

        private double? mOGrossWeight;
        public double? MOGrossWeight
        {
            get { return mOGrossWeight; }
            set 
            {
                mOGrossWeight = value;
                OnPropertyChanged("MOGrossWeight"); 
            }
        }

        private double? mONetWeight;
        public double? MONetWeight
        {
            get { return mONetWeight; }
            set 
            {
                mONetWeight = value;
                OnPropertyChanged("MONetWeight");
            }
        }

        private Int32? mONoOfCartons;
        public Int32? MONoOfCartons
        {
            get { return mONoOfCartons; }
            set 
            {
                mONoOfCartons = value;
                OnPropertyChanged("MONoOfCartons");
            }
        }

        private Int32? mOPayFlag;
        public Int32? MOPayFlag
        {
            get { return mOPayFlag; }
            set 
            {
                mOPayFlag = value;
                OnPropertyChanged("MOPayFlag");
            }
        }

        #endregion Instance Properties

        private String mOAgentNoDesc;
        public String MOAgentNoDesc
        {
            get { return mOAgentNoDesc; }
            set 
            {
                mOAgentNoDesc = value;
                OnPropertyChanged("MOAgentNoDesc");
            }
        }

        private String mOTransporterDesc;
        public String MOTransporterDesc
        {
            get { return mOTransporterDesc; }
            set 
            {
                mOTransporterDesc = value;
                OnPropertyChanged("MOTransporterDesc");
            }
        }

        private String mOTranspMethodDesc;
        public String MOTranspMethodDesc
        {
            get { return mOTranspMethodDesc; }
            set 
            {
                mOTranspMethodDesc = value;
                OnPropertyChanged("MOTranspMethodDesc");
            }
        }

        private String mOPackingMethodDesc;
        public String MOPackingMethodDesc
        {
            get { return mOPackingMethodDesc; }
            set 
            {
                mOPackingMethodDesc = value;
                OnPropertyChanged("MOPackingMethodDesc");
            }
        }
    }
}
