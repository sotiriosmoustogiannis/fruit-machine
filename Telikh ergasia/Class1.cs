using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telikh_ergasia
{
    public class SlotMachine
    {
        public int slot;

        public SlotMachine(int sthlh1)
        {
            slot = sthlh1;
        }

        public SlotMachine()
        {
            slot = 0;
        }
        public void SetSlot(int slot1)
        {
            slot = slot1;
        }
        public int GetSlot()
        {
            return slot;
        }

    }
}
