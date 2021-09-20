using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class MlayoutcMLAYOUTCSiblingRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? HeaderRecID { get; set; }
        public Int16? MLAYC_iCounter { get; set; }
        public Int16? MLAYC_iOperationNo { get; set; }
        public Int16? MLAYC_iAdditionalCodeNo { get; set; }
        public double? MLAYC_SMV_TimeToMake { get; set; }
        public Int16? MLAYC_MinutesDaily { get; set; }
        public Int32? MLAYC_HundredPercEff { get; set; }
        public Int32? MLAYC_DailyGoal { get; set; }
        public double? MLAYC_OperatorsRequired { get; set; }
        public Int16? MLAYC_OperatorsActual { get; set; }
        public String MLAYC_iLink { get; set; }
        public Int16? MLAYC_OperatorSelect { get; set; }
        public Int32? MLAYC_ActualMinutes { get; set; }
        public Int16? MLAYC_iEquipmentNo { get; set; }
        public Int16? MLAYC_iEquipmentCategoryNo { get; set; }
        public Int16? MLAYC_iAttachmentsNo { get; set; }

        #endregion Instance Properties
    }
}
