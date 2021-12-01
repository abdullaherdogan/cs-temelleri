using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    class Anti_Terorist : IPlayer
    {
        private IGun _gun;
        public Anti_Terorist(IGun gun)
        {
            if (gun.CanCounterUse==false)
            {
                throw new Exception("Bu silahi counterlar kullanamaz");
            }
            _gun = gun;
        }
        public void AtesEt()
        {
            _gun.AtesEt();
        }
    }
}
