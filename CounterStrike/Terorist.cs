using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    class Terorist:IPlayer
    {
        private IGun _ak47;
        public Terorist(Ak47 ak47)
        {
            _ak47 = ak47;
        }
        public void AtesEt()
        {
            _ak47.AtesEt();
        }
    }
}
