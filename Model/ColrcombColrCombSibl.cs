using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class ColrcombColrCombSibl : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? CombMainID { get; set; }
        public Int16? CLCMMatPart { get; set; }
        public Int16? CLCMMatMatr { get; set; }
        public String CLCMMatCode { get; set; }
        public Int16? CLCMMatColr { get; set; }
        public Int16? CLCMMatSupl { get; set; }
        #endregion Instance Properties

        // Used for Database Relationship
        public Int32 KeyId { get; set; }

        public ColrcombColrCombSibl()
        {
            ID = 0;
            KeyId = 0;
            CombMainID = 0;
        }
    }
}
