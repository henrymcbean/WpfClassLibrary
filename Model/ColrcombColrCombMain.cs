using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class ColrcombColrCombMain : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String CLCMStyle { get; set; }
        public String CLCMVarn { get; set; }
        public Int16? CLCMPartNo { get; set; }
        public Int16? CLCMMatrNo { get; set; }
        public Int16? CLCMColrNo { get; set; }
        public String CLCMMainCode { get; set; }
        #endregion Instance Properties


        // Used for Database Relationship
        public Int32 KeyId { get; set; }

        public ColrcombColrCombMain()
        {
            ID = 0;
            KeyId = 0;
            CLCMPartNo = 0;
            CLCMMatrNo = 0;
            CLCMColrNo = 0;
            CLCMMainCode = "";
        }
    }
}
