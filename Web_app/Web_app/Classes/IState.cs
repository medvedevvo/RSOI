using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Classes
{
    public interface IState
    {
        bool to_working();
        bool switch_on();
        bool switch_off();
        bool to_waiting();
    }
}
