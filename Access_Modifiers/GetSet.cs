﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class GetSet
    {
        private string _myText;
        public string MyText
        {
            get
                { return _myText + "Ok ok"; }
            set { _myText = value; }
        }

    }
}
