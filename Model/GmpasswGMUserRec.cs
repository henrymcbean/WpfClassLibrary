using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class GmpasswGMUserRec
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public String GMUserCode { get; set; }
        public String GMUserName { get; set; }
        public String GMUserEMail { get; set; }
        public String GMUserDir { get; set; }
        public Int16? GMUserNumber { get; set; }
        public Int16? GMUserManagement1 { get; set; }
        public Int16? GMUserManagement2 { get; set; }
        public Int16? GMUserManagement3 { get; set; }
        public Int16? GMUserManagement4 { get; set; }

        #endregion Instance Properties
    }
}
