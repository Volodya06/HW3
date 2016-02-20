﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertronApp
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("Silent Bob")
        {

        }

        public override void FetchNewNumber(int num)
        {
            if (num.IsEven())
            {
                Score++;
            }
        }
    }
}
