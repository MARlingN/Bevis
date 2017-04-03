using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevis
{
    class tjek4
    {
        public string erdet(int a, int b)
        {
            string ord = "no";
            int c = a + b;
            if (c == 12)
            {
                ord = "yes";
            }
            return ord;
        }
    }
}
