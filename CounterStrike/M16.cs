using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class M16 : IGun, IM16
    {
        public void AtesEt()
        {
            Console.WriteLine("M16 ile ates edildi");
        }
    }
}
