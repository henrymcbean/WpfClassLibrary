using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class CstextraCSTExtraRec : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }

        private String csteStyle;
        public String CSTEStyle 
        {
            get { return csteStyle; }
            set
            {
                csteStyle = value;
                OnPropertyChanged("CSTEStyle");
            }
        }

        private String csteVarn;
        public String CSTEVarn 
        {
            get { return csteVarn; }
            set
            {
                csteVarn = value;
                OnPropertyChanged("CSTEVarn");
            }
        }

        private String csteIntraStat1;
        public String CSTEIntraStat1 
        {
            get { return csteIntraStat1; }
            set
            {
                csteIntraStat1 = value;
                OnPropertyChanged("CSTEIntraStat1");
            }
        }

        private String csteIntraStat2;
        public String CSTEIntraStat2 
        {
            get { return csteIntraStat2; }
            set
            {
                csteIntraStat2 = value;
                OnPropertyChanged("CSTEIntraStat2");
            }
        }

        private String csteCommodityCode3;
        public String CSTECommodityCode3 
        {
            get { return csteCommodityCode3; }
            set
            {
                csteCommodityCode3 = value;
                OnPropertyChanged("CSTECommodityCode3");
            }
        }

        private String csteCommodityCode4;
        public String CSTECommodityCode4 
        {
            get { return csteCommodityCode4; }
            set
            {
                csteCommodityCode4 = value;
                OnPropertyChanged("CSTECommodityCode4");
            }
        }

        private String csteCommodityCode5;
        public String CSTECommodityCode5
        {
            get { return csteCommodityCode5; }
            set
            {
                csteCommodityCode5 = value;
                OnPropertyChanged("CSTECommodityCode5");
            }
        }

        private String csteCommodityCode6;
        public String CSTECommodityCode6
        {
            get { return csteCommodityCode6; }
            set
            {
                csteCommodityCode6 = value;
                OnPropertyChanged("CSTECommodityCode6");
            }
        }

        public String CSTEMatSeason { get; set; }

        private Int16? csteFlag1;
        public Int16? CSTEFlag1 
        {
            get { return csteFlag1; }
            set
            {
                csteFlag1 = value;
                OnPropertyChanged("CSTEFlag1");
            }
        }

        private Int16? csteFlag2;
        public Int16? CSTEFlag2
        {
            get { return csteFlag2; }
            set
            {
                csteFlag2 = value;
                OnPropertyChanged("CSTEFlag2");
            }
        }

        private Int16? csteFlag3;
        public Int16? CSTEFlag3
        {
            get { return csteFlag3; }
            set
            {
                csteFlag3 = value;
                OnPropertyChanged("CSTEFlag3");
            }
        }

        private Int16? csteFlag4;
        public Int16? CSTEFlag4
        {
            get { return csteFlag4; }
            set
            {
                csteFlag4 = value;
                OnPropertyChanged("CSTEFlag4");
            }
        }

        private Int32? csteFactory;
        public Int32? CSTEFactory 
        {
            get { return csteFactory; }
            set
            {
                csteFactory = value;
                OnPropertyChanged("CSTEFactory");
            }
        }

        private Int32? csteNominalCode;
        public Int32? CSTENominalCode 
        {
            get { return csteNominalCode; }
            set
            {
                csteNominalCode = value;
                OnPropertyChanged("CSTENominalCode");
            }
        }
        #endregion Instance Properties


        private bool[] matSeason;
        public bool[] MatSeason
        {
            get { return matSeason; }
            set
            {
                matSeason = value;
                OnPropertyChanged("MatSeason");
            }
        }

        private String factoryDescr;
        public String FactoryDescr
        {
            get { return factoryDescr; }
            set
            {
                factoryDescr = value;
                OnPropertyChanged("FactoryDescr");
            }
        }

        private String nominalCodeDescr;
        public String NominalCodeDescr
        {
            get { return nominalCodeDescr; }
            set
            {
                nominalCodeDescr = value;
                OnPropertyChanged("NominalCodeDescr");
            }
        }

        public CstextraCSTExtraRec()
        {
            ID = 0;
            CSTEStyle = "";
            CSTEVarn = "";
            CSTEIntraStat1 = "";
            CSTEIntraStat2 = "";
            CSTECommodityCode3 = "";
            CSTECommodityCode4 = "";
            CSTECommodityCode5 = "";
            CSTECommodityCode6 = "";
            CSTEMatSeason = "";
            CSTEFlag1 = 0;
            CSTEFlag2 = 0;
            CSTEFlag3 = 0;
            CSTEFlag4 = 0;
            CSTEFactory = 0;
            CSTENominalCode = 0;

            matSeason = new bool[4];
        }
    }
}
