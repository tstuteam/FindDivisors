using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDivisors
{
    

        public static void Main()
        {
            var divis = new Divisors();
            Console.WriteLine(divis.StrDict(divis.TwoDivisors(1, 16)));
        }
    }
}
