using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmcopersGMCOpersRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32 OperID { get; set; }

        private Int16? gmcOperNo;
        public Int16? GMCOperNo 
        {
            get { return gmcOperNo; }
            set
            {
                gmcOperNo = value;
                OnPropertyChanged("GMCOperNo");
            }
        }

        private Int16? gmcOCodeNo;
        public Int16? GMCOCodeNo 
        {
            get { return gmcOCodeNo; }
            set
            {
                gmcOCodeNo = value;
                OnPropertyChanged("GMCOCodeNo");
            }
        }

        private double? gmcOCostToMake;
        public double? GMCOCostToMake 
        {
            get { return gmcOCostToMake; }
            set
            {
                gmcOCostToMake = value;
                OnPropertyChanged("GMCOCostToMake");
            }
        }

        private double? gmcOTimeToMake;
        public double? GMCOTimeToMake 
        {
            get { return gmcOTimeToMake; }
            set
            {
                gmcOTimeToMake = value;
                OnPropertyChanged("GMCOTimeToMake");
            }
        }
        public Int16? GMCOEquipmentNo { get; set; }


        private Int16? gmcOEquipmentTypeNo;
        public Int16? GMCOEquipmentTypeNo 
        {
            get { return gmcOEquipmentTypeNo; }
            set
            {
                gmcOEquipmentTypeNo = value;
                OnPropertyChanged("GMCOEquipmentTypeNo");
            }
        }

        private Int16? gmcOActionNo;
        public Int16? GMCOActionNo 
        {
            get { return gmcOActionNo; }
            set
            {
                gmcOActionNo = value;
                OnPropertyChanged("GMCOActionNo");
            }
        }

        private Int16? gmcOComplexityNo;
        public Int16? GMCOComplexityNo 
        {
            get { return gmcOComplexityNo; }
            set
            {
                gmcOComplexityNo = value;
                OnPropertyChanged("GMCOComplexityNo");
            }
        }
        #endregion Instance Properties

        private short index;
        public short Index
        {
            get { return index; }
            set
            {
                index = value;
                OnPropertyChanged("Index");
            }
        }

        private String operNoDesc;
        public String OperNoDesc
        {
            get { return operNoDesc; }
            set
            {
                operNoDesc = value;
                OnPropertyChanged("OperNoDesc");
            }
        }

        private String oCodeNoDesc;
        public String OCodeNoDesc
        {
            get { return oCodeNoDesc; }
            set
            {
                oCodeNoDesc = value;
                OnPropertyChanged("OCodeNoDesc");
            }
        }

        private double? timeToMakeInSeconds;
        public double? TimeToMakeInSeconds
        {
            get { return timeToMakeInSeconds; }
            set
            {
                timeToMakeInSeconds = value;
                OnPropertyChanged("TimeToMakeInSeconds");
            }
        }


        private String oEquipmentNo;
        public String OEquipmentNo
        {
            get { return oEquipmentNo; }
            set
            {
                oEquipmentNo = value;
                OnPropertyChanged("OEquipmentNo");
            }
        }

        private String oEquipmentTypeNoDesc;
        public String OEquipmentTypeNoDesc
        {
            get { return oEquipmentTypeNoDesc; }
            set
            {
                oEquipmentTypeNoDesc = value;
                OnPropertyChanged("OEquipmentTypeNoDesc");
            }
        }

        private double? totalCostToMake;
        public double? TotalCostToMake
        {
            get { return totalCostToMake; }
            set
            {
                totalCostToMake = value;
                OnPropertyChanged("TotalCostToMake");
            }
        }

        public GmcopersGMCOpersRec()
        {
            ID = 0;
            OperID = 0;
            GMCOComplexityNo = 0;
        }
    }
}
