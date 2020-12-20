using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telikh_ergasia
{
    public class Money
    {
        public int kerdos;

        public Money(int bet)
        {
            kerdos = bet;
        }

        public Money()
        {
            kerdos = 0;
        }

        public void SetKerdos(int bet1,int sthles,int frouta)
        {
            kerdos = bet1*sthles*frouta;
        }
        public int GetKerdos()
        {
            return kerdos;
        }
    }
}
