using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfClassLibrary.Model
{
    public class DocketStyles
    {
        #region Instance Properties
         public Int32 ID { get; set; } 
         public Int32? DocketID { get; set; } 
         public String StyleCode { get; set; } 
         public String VarnCode { get; set; } 
         public String StyleVarnIssued { get; set; } 
         public String StyleVarnOutsd { get; set; } 
         public String StyleVarnCompl { get; set; } 
         public String StyleDescription { get; set; } 
         public Int16? StyleType { get; set; } 
         public Int32? STFileNumber { get; set; } 
         public Int16? STDeliveryIndex { get; set; } 
         public Int16? DeliveryPoint { get; set; } 
         public DateTime? STDeliveryDate { get; set; } 
         public DateTime? STCuttingDate { get; set; } 
         public double? STCmtPrice { get; set; } 
         public double? STTimeToMake { get; set; } 
         public Int16? STProductionLine { get; set; } 
         public double? GradingValue { get; set; } 
         public double? Costing { get; set; } 
         public double? TotalMatCost { get; set; } 
         public double? SellingPrice { get; set; } 
         public Int16? MinExpSz { get; set; } 
         public Int16? MinUkSz { get; set; } 
         public String ExpSzKey { get; set; } 
         public String UkSzKey { get; set; } 
         public Int16? Supplier { get; set; } 
         public String MainMatCodeIssued { get; set; } 
         public String MainMatCodeOutsd { get; set; } 
         public String MainMatCodeCompl { get; set; } 

        #endregion Instance Properties

         public String DelivNoteNo { get; set; }
         public String DeliveryPointDesc { get; set; }
         public String MainMatCodeIssuedDesc { get; set; } 

        public DocketStyles()
        {
            DocketID = 0;

            StyleVarnIssued =
            StyleVarnOutsd =
            StyleVarnCompl = "";

            StyleType = 0;

            STFileNumber = 0;
            STDeliveryIndex = 0;

            DeliveryPoint = 0;

            STCmtPrice = 0.0;
            STTimeToMake = 0.0;
            STProductionLine = 0;

            GradingValue =
            Costing =
            TotalMatCost =
            SellingPrice = 0.0;

            MinExpSz =
            MinUkSz = 0;
            Supplier = 0;

            MainMatCodeIssued =
            MainMatCodeOutsd =
            MainMatCodeCompl = "";
        }
    }
}
