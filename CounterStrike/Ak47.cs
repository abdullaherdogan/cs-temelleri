using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    class Ak47 : IGun
    {
        public bool CanTeroristUse { get => true; }
        public bool CanCounterUse { get => false;}

        public void AtesEt()
        {
            Console.WriteLine("ak47 ile ates edildi");
        }
    }
}
