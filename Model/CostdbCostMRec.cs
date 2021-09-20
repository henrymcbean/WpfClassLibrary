using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class CostdbCostMRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 CostdbID { get; set; }
        public String CTInitials { get; set; }
        public String CTStyle { get; set; }
        public String CTVarn { get; set; }
        public String CTStyleVarn { get; set; }
        public Int32? CTSerialNumber { get; set; }


        private String ctStyleDescr;
        public String CTStyleDescr 
        {
            get { return ctStyleDescr; }
            set
            {
                ctStyleDescr = value;
                OnPropertyChanged("CTStyleDescr");
            }
        }

        public String CTMainFabric { get; set; }


        private Int16? ctGarType;
        public Int16? CTGarType 
        {
            get { return ctGarType; }
            set
            {
                ctGarType = value;
                OnPropertyChanged("CTGarType");
            }
        }

        public DateTime? CTDesignDate { get; set; }
        public DateTime? CTDate2 { get; set; }


        private Int16? ctMinExpSz;
        public Int16? CTMinExpSz 
        {
            get { return ctMinExpSz; }
            set
            {
                ctMinExpSz = value;
                OnPropertyChanged("CTMinExpSz");
            }
        }

        private Int16? ctMinUkSz;
        public Int16? CTMinUkSz 
        {
            get { return ctMinUkSz; }
            set
            {
                ctMinUkSz = value;
                OnPropertyChanged("CTMinUkSz");
            }
        }


        public String CTExpSzKey { get; set; }


        private String ctUkSzKey;
        public String CTUkSzKey 
        {
            get { return ctUkSzKey; }
            set
            {
                ctUkSzKey = value;
                OnPropertyChanged("CTUkSzKey");
            }
        }
        public String CTGrdingSz { get; set; }
        public Int16 CTVatNo { get; set; }


        private double? ctVatRate;
        public double? CTVatRate 
        {
            get { return ctVatRate; }
            set
            {
                ctVatRate = value;
                OnPropertyChanged("CTVatRate");
            }
        }

        public double? CTGrading { get; set; }


        private double? ctTimeToMake;
        public double? CTTimeToMake 
        {
            get { return ctTimeToMake; }
            set
            {
                ctTimeToMake = value;
                OnPropertyChanged("CTTimeToMake");
            }
        }


        private double? ctTotMatCost;
        public double? CTTotMatCost 
        {
            get { return ctTotMatCost; }
            set 
            {
                ctTotMatCost = value;
                OnPropertyChanged("CTTotMatCost");
            } 
        }


        public double? CTCostMaking { get; set; }

        private double? ctDutyPer;
        public double? CTDutyPer 
        {
            get { return ctDutyPer; }
            set
            {
                ctDutyPer = value;
                OnPropertyChanged("CTDutyPer");
            } 
        }


        private double? ctDuty;
        public double? CTDuty 
        {
            get { return ctDuty; }
            set
            {
                ctDuty = value;
                OnPropertyChanged("CTDuty");
            }
        }


        private double? ctOverHeadsPer;
        public double? CTOverHeadsPer 
        {
            get { return ctOverHeadsPer; }
            set
            {
                ctOverHeadsPer = value;
                OnPropertyChanged("CTOverHeadsPer");
            }
        }


        private double? ctOverHeads;
        public double? CTOverHeads 
        {
            get { return ctOverHeads; }
            set
            {
                ctOverHeads = value;
                OnPropertyChanged("CTOverHeads");
            }
        }


        private double? ctContinPer;
        public double? CTContinPer 
        {
            get { return ctContinPer; }
            set
            {
                ctContinPer = value;
                OnPropertyChanged("CTContinPer");
            }
        }

        private double? ctContin;
        public double? CTContin 
        {
            get { return ctContin; }
            set
            {
                ctContin = value;
                OnPropertyChanged("CTContin");
            }
        }

        private double? ctTotManCost;
        public double? CTTotManCost 
        {
            get { return ctTotManCost; }
            set
            {
                ctTotManCost = value;
                OnPropertyChanged("CTTotManCost");
            }
        }


        private double? ctProfMarPer1;
        public double? CTProfMarPer1 
        {
            get { return ctProfMarPer1; }
            set
            {
                ctProfMarPer1 = value;
                OnPropertyChanged("CTProfMarPer1");
            }
        }

        private double? ctProfMar1;
        public double? CTProfMar1 
        {
            get { return ctProfMar1; }
            set
            {
                ctProfMar1 = value;
                OnPropertyChanged("CTProfMar1");
            }
        }


        public double? CTProfMarPer2 { get; set; }
        public double? CTProfMar2 { get; set; }
        public double? CTProfMarPer3 { get; set; }
        public double? CTProfMar3 { get; set; }
        public double? CTProfMarPer4 { get; set; }
        public double? CTProfMar4 { get; set; }


        private double? ctSelPrice1;
        public double? CTSelPrice1 
        {
            get { return ctSelPrice1; }
            set
            {
                ctSelPrice1 = value;
                OnPropertyChanged("CTSelPrice1");
            }
        }


        private double? selPrice2Percent;
        public double? SelPrice2Percent
        {
            get { return selPrice2Percent; }
            set
            {
                selPrice2Percent = value;
                OnPropertyChanged("SelPrice2Percent");
            } 
        }


        private double? ctSelPricePer2;
        public double? CTSelPricePer2 
        {
            get { return ctSelPricePer2; }
            set 
            {
                ctSelPricePer2 = value;
                OnPropertyChanged("CTSelPricePer2");
            } 
        }


        private double? ctSelPrice2;
        public double? CTSelPrice2 
        {
            get { return ctSelPrice2; }
            set
            {
                ctSelPrice2 = value;
                OnPropertyChanged("CTSelPrice2");
            }
        }

        private double? selPrice3Percent;
        public double? SelPrice3Percent
        {
            get { return selPrice3Percent; }
            set
            {
                selPrice3Percent = value;
                OnPropertyChanged("SelPrice3Percent");
            }
        }
        public double? CTSelPricePer3 { get; set; }


        private double? ctSelPrice3;
        public double? CTSelPrice3 
        {
            get { return ctSelPrice3; }
            set
            {
                ctSelPrice3 = value;
                OnPropertyChanged("CTSelPrice3");
            }
        }


        private double? selPrice4Percent;
        public double? SelPrice4Percent
        {
            get { return selPrice4Percent; }
            set
            {
                selPrice4Percent = value;
                OnPropertyChanged("SelPrice4Percent");
            }
        }


        private double? ctSelPricePer4;
        public double? CTSelPricePer4 
        {
            get { return ctSelPricePer4; }
            set
            {
                ctSelPricePer4 = value;
                OnPropertyChanged("CTSelPricePer4");
            }
        }


        private double? ctSelPrice4;
        public double? CTSelPrice4 
        {
            get { return ctSelPrice4; }
            set
            {
                ctSelPrice4 = value;
                OnPropertyChanged("CTSelPrice4");
            }
        }

        public Int16? CTProfSelFlag { get; set; }
        public double? CTTotMatCostF { get; set; }


        private double? ctCostMakingF;
        public double? CTCostMakingF 
        {
            get { return ctCostMakingF; }
            set
            {
                ctCostMakingF = value;
                OnPropertyChanged("CTCostMakingF");
            }
        }

        private double? ctDutyF;
        public double? CTDutyF 
        {
            get { return ctDutyF; }
            set
            {
                ctDutyF = value;
                OnPropertyChanged("CTDutyF");
            }
        }


        private double? ctOverHeadsF;
        public double? CTOverHeadsF 
        {
            get { return ctOverHeadsF; }
            set
            {
                ctOverHeadsF = value;
                OnPropertyChanged("CTOverHeadsF");
            }
        }
        public double? CTContinF { get; set; }


        private double? ctTotManCostF;
        public double? CTTotManCostF 
        {
            get { return ctTotManCostF; }
            set
            {
                ctTotManCostF = value;
                OnPropertyChanged("CTTotManCostF");
            }
        }


        private double? ctProfMar1F;
        public double? CTProfMar1F 
        {
            get { return ctProfMar1F; }
            set
            {
                ctProfMar1F = value;
                OnPropertyChanged("CTProfMar1F");
            }
        }

        public double? CTProfMar2F { get; set; }
        public double? CTProfMar3F { get; set; }
        public double? CTProfMar4F { get; set; }
        public Int16? CTCurrNoX { get; set; }
        public double? CTTotMatCostX { get; set; }
        public double? CTCostMakingX { get; set; }
        public double? CTDutyX { get; set; }
        public double? CTOverHeadsX { get; set; }
        public double? CTContinX { get; set; }
        public double? CTTotManCostX { get; set; }
        public double? CTProfMar1X { get; set; }
        public double? CTProfMar2X { get; set; }
        public double? CTProfMar3X { get; set; }
        public double? CTProfMar4X { get; set; }
        public double? CTSelPrice1X { get; set; }


        private double? ctDiscountPer;
        public double? CTDiscountPer 
        {
            get { return ctDiscountPer; }
            set
            {
                ctDiscountPer = value;
                OnPropertyChanged("CTDiscountPer");
            }
        }

        public double? CTVatPerc { get; set; }
        public double? CTSpareVar1 { get; set; }
        public double? CTSpareVar2 { get; set; }


        private Int16? ctSpareShort1;
        public Int16? CTSpareShort1 
        {
            get { return ctSpareShort1; }
            set
            {
                ctSpareShort1 = value;
                OnPropertyChanged("CTSpareShort1");
            }
        }


        private Int16? ctSpareShort2;
        public Int16? CTSpareShort2 
        {
            get { return ctSpareShort2; }
            set
            {
                ctSpareShort2 = value;
                OnPropertyChanged("CTSpareShort2");
            }
        }


        private Int16? ctCountryCode;
        public Int16? CTCountryCode 
        {
            get { return ctCountryCode; }
            set
            {
                ctCountryCode = value;
                OnPropertyChanged("CTCountryCode");
            }
        }


        private double? ctCountryPerc;
        public double? CTCountryPerc 
        {
            get { return ctCountryPerc; }
            set
            {
                ctCountryPerc = value;
                OnPropertyChanged("CTCountryPerc");
            }
        }
        public Int16? CTFreeFormatFlag { get; set; }
        #endregion Instance Properties

        private double? selPricePlusVat;
        public double? SelPricePlusVat
        {
            get { return selPricePlusVat; }
            set
            {
                selPricePlusVat = value;
                OnPropertyChanged("SelPricePlusVat");
            }
        }

        private double profMarginPerc;
        public double ProfMarginPerc
        {
            get { return profMarginPerc; }
            set 
            {
                profMarginPerc = value;
                OnPropertyChanged("ProfMarginPerc");
            }
        }


        private double? currcyDiff;
        public double? CurrcyDiff
        {
            get { return currcyDiff; }
            set
            {
                currcyDiff = value;
                OnPropertyChanged("CurrcyDiff");
            }
        }

        private double? qPRMatTotal;
        public double? QPRMatTotal
        {
            get { return qPRMatTotal; }
            set
            {
                qPRMatTotal = value;
                OnPropertyChanged("QPRMatTotal");
            }
        }

        private double? qprPerc;
        public double? QprPerc
        {
            get { return qprPerc; }
            set
            {
                qprPerc = value;
                OnPropertyChanged("QprPerc");
            }
        }


        private double? sellPricePerc;
        public double? SellPricePerc
        {
            get { return sellPricePerc; }
            set
            {
                sellPricePerc = value;
                OnPropertyChanged("SellPricePerc");
            }
        }

        private double? styleMarkUpPerc;
        public double? StyleMarkUpPerc
        {
            get { return styleMarkUpPerc; }
            set
            {
                styleMarkUpPerc = value;
                OnPropertyChanged("StyleMarkUpPerc");
            }
        }


        private double? profMarPercDisc;
        public double? ProfMarPercDisc
        {
            get { return profMarPercDisc; }
            set
            {
                profMarPercDisc = value;
                OnPropertyChanged("ProfMarPercDisc");
            }
        }

        private double? discValue;
        public double? DiscValue
        {
            get { return discValue; }
            set
            {
                discValue = value;
                OnPropertyChanged("DiscValue");
            }
        }

        private double? materialCostF;
        public double? MaterialCostF
        {
            get { return materialCostF; }
            set 
            {
                materialCostF = value;
                OnPropertyChanged("MaterialCostF");
            }
        }

        private double? profirMarginF;
        public double? ProfirMarginF
        {
            get { return profirMarginF; }
            set
            {
                profirMarginF = value;
                OnPropertyChanged("ProfirMarginF");
            }
        }

        private double? buyingRate;
        public double? BuyingRate
        {
            get { return buyingRate; }
            set { buyingRate = value; }
        }

        private double? sellingRate;
        public double? SellingRate
        {
            get { return sellingRate; }
            set { sellingRate = value; }
        }

        public CostdbCostMRec()
        {
            CTInitials = "";
            CTStyle = "";
            CTVarn = "";
            CTStyleVarn = "";
            CTSerialNumber = 0;
            ctStyleDescr = "";
            CTMainFabric = "";
            ctGarType = null;
            CTDesignDate = DateTime.Now;
            CTDate2 = DateTime.Parse("1900-01-01 00:00:00");
            ctMinExpSz = null;
            ctMinUkSz = (short)DateTime.Now.Year;
            CTExpSzKey = "";
            ctUkSzKey = "";
            CTGrdingSz = "";
            CTVatNo = 0;
            ctVatRate = 0.0;
            CTGrading = 0.0;
            ctTimeToMake = 0.0;
            ctTotMatCost = 0.0;
            CTCostMaking = 0.0;
            ctDutyPer = 0.0;
            ctDuty = 0.0;
            ctOverHeadsPer = 0.0;
            ctOverHeads = 0.0;
            ctContinPer = 0.0;
            ctContin = 0.0;
            ctTotManCost = 0.0;
            ctProfMarPer1 = 0.0;
            ctProfMar1 = 0.0;
            CTProfMarPer2 = 0.0;
            CTProfMar2 = 0.0;
            CTProfMarPer3 = 0.0;
            CTProfMar3 = 0.0;
            CTProfMarPer4 = 0.0;
            CTProfMar4 = 0.0;
            ctSelPrice1 = 0.0;
            CTSelPricePer2 = 0.0;
            CTSelPrice2 = 0.0;
            CTSelPricePer3 = 0.0;
            CTSelPrice3 = 0.0;
            CTSelPricePer4 = 0.0;
            CTSelPrice4 = 0.0;
            CTProfSelFlag = 0;
            CTTotMatCostF = 0.0;
            CTCostMakingF = 0.0;
            CTDutyF = 0.0;
            CTOverHeadsF = 0.0;
            CTContinF = 0.0;
            CTTotManCostF = 0.0;
            CTProfMar1F = 0.0;
            CTProfMar2F = 0.0;
            CTProfMar3F = 0.0;
            CTProfMar4F = 0.0;
            CTCurrNoX = 0;
            CTTotMatCostX = 0.0;
            CTCostMakingX = 0.0;
            CTDutyX = 0.0;
            CTOverHeadsX = 0.0;
            CTContinX = 0.0;
            CTTotManCostX = 0.0;
            CTProfMar1X = 0.0;
            CTProfMar2X = 0.0;
            CTProfMar3X = 0.0;
            CTProfMar4X = 0.0;
            CTSelPrice1X = 0.0;
            CTDiscountPer = 0.0;
            CTVatPerc = 0.0;
            CTSpareVar1 = 0.0;
            CTSpareVar2 = 0.0;
            CTSpareShort1 = null;
            CTSpareShort2 = null;
            CTCountryCode = 0;
            CTCountryPerc = 0.0;
            CTFreeFormatFlag = 0;

            // Form Propeties
            selPrice2Percent = 0.0;
            selPrice3Percent = 0.0;
            selPrice4Percent = 0.0;
            selPricePlusVat = 0.0;
            profMarginPerc = 0.0;
            qPRMatTotal = 0.0;
            qprPerc = 0.0;
            sellPricePerc = 0.0;
            styleMarkUpPerc = 0.0;
            profMarPercDisc = 0.0;
            BuyingRate = 0.0;
        }
    }
}
