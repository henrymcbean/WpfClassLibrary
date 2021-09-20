using System;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace WpfClassLibrary.Model
{
    public class GmcurrsCURCurrenciesRec : INotifyPropertyChanged
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public Int32 CURCurrencyKey { get; set; }

        private String curCountry;
        public String CURCountry 
        {
            get { return curCountry; }
            set
            {
                curCountry = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURCountry"));
            }
        }

        private String curCurrency;
        public String CURCurrency 
        {
            get { return curCurrency; }
            set 
            {
                curCurrency = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURCurrency"));
            }
        }

        private double? curBuyingRate;
        public double? CURBuyingRate 
        {
            get { return curBuyingRate; }
            set 
            {
                curBuyingRate = (double?)value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURBuyingRate"));
            } 
        }

        private double? curSellingRate;
        public double? CURSellingRate 
        {
            get { return curSellingRate; }
            set
            {
                curSellingRate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURSellingRate"));
            }
        }
        public DateTime? CURDate { get; set; }

        private String curComments;
        public String CURComments 
        {
            get { return curComments; }
            set 
            {
                curComments = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURComments"));
            }
        }

        private String curFlag;
        public String CURFlag 
        {
            get { return curFlag; }
            set 
            {
                curFlag = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CURFlag"));
            }
        }
        #endregion Instance Properties

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
