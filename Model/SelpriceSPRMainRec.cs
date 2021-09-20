﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class SelpriceSPRMainRec : ViewModelBase
    {
        #region Instance Properties
        public Int32 ID { get; set; }
        public String SPRStyle { get; set; }
        public String SPRVarn { get; set; }

        #endregion Instance Properties

        public SelpriceSPRMainRec()
        {
            ID = 0;
        }
    }
}
