﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace code1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "firstcode" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select firstcode.svc or firstcode.svc.cs at the Solution Explorer and start debugging.
    public class firstcode : Ifirstcode
    {
        public string Message()
        {
            return "Hellow World";
        }
    }
}
