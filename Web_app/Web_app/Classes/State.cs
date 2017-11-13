using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Classes;

namespace WebApp.Classes
{
    public enum States : byte { ON, OFF, IN_WORK, WAIT }
    public class State : IState
    {
        public byte state { get { return state; } set { } }

        public State()
        {
            state = (byte)States.OFF;
        }
        public bool to_working()
        {
            if (state == (byte)States.ON || state == (byte)States.WAIT)
            {
                state = (byte)States.IN_WORK;
                return true;
            }
            return false;
        }

        public bool switch_on()
        {
            if (state == (byte)States.OFF)
            {
                state = (byte)States.ON;
                return true;
            }
            return false;
        }

        public bool switch_off()
        {
            if (state != (byte)States.OFF)
            {
                state = (byte)States.OFF;
                return true;
            }
            return false;
        }

        public bool to_waiting()
        {
            if (state == (byte)States.ON || state == (byte)States.IN_WORK)
            {
                state = (byte)States.WAIT;
                return true;
            }
            return false;
        }
    }
}
