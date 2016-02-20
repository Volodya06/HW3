using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertronApp
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay")
        {

        }

        public override void FetchNewNumber(int num)
        {
            if (!num.IsEven())
            {
                Score++;
            }
        }
    }
}
