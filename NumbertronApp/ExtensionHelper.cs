using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertronApp
{
    //методы расширения
    public static class ExtensionHelper
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
