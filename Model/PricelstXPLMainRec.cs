using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class PricelstXPLMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String XPLStyle { get; set; }
        public String XPLVarn { get; set; }

        private Int16? xplCurrencyNo;
        public Int16? XPLCurrencyNo 
        {
            get { return xplCurrencyNo; }
            set
            {
                xplCurrencyNo = value;
                OnPropertyChanged("XPLCurrencyNo");
            }
        }

        private double? xplSelPrice1;
        public double? XPLSelPrice1 
        {
            get { return xplSelPrice1; }
            set
            {
                xplSelPrice1 = value;
                OnPropertyChanged("XPLSelPrice1");
            }
        }


        private double? xplSelPrice2;
        public double? XPLSelPrice2
        {
            get { return xplSelPrice2; }
            set
            {
                xplSelPrice2 = value;
                OnPropertyChanged("XPLSelPrice2");
            }
        }

        private double? xplSelPrice3;
        public double? XPLSelPrice3
        {
            get { return xplSelPrice3; }
            set
            {
                xplSelPrice3 = value;
                OnPropertyChanged("XPLSelPrice3");
            }
        }

        private double? xplSelPrice4;
        public double? XPLSelPrice4
        {
            get { return xplSelPrice4; }
            set
            {
                xplSelPrice4 = value;
                OnPropertyChanged("XPLSelPrice4");
            }
        }

        private double? xplSelPrice5;
        public double? XPLSelPrice5
        {
            get { return xplSelPrice5; }
            set
            {
                xplSelPrice5 = value;
                OnPropertyChanged("XPLSelPrice5");
            }
        }

        private double? xplSelPrice6;
        public double? XPLSelPrice6
        {
            get { return xplSelPrice6; }
            set
            {
                xplSelPrice6 = value;
                OnPropertyChanged("XPLSelPrice6");
            }
        }
        #endregion Instance Properties

        private String sCurrcyDesc;
        public String CurrcyDesc
        {
            get { return sCurrcyDesc; }
            set
            {
                sCurrcyDesc = value;
                OnPropertyChanged("CurrcyDesc");
            }
        }

        private String styleDesc;
        public String StyleDesc
        {
            get { return styleDesc; }
            set
            {
                styleDesc = value;
                OnPropertyChanged("StyleDesc");
            }
        }

        public PricelstXPLMainRec()
        {
            ID = 0;
        }
    }
}
