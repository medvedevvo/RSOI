using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Classes;

namespace WebApp.Controllers
{
    [Route("api/")]
    public class StateController
    {
        IState st;


        public StateController(IState s)
        {
            this.st = s;
        }

        [HttpGet("to_working")]
        public bool to_Work()
        {
            return st.to_working();
        }

        [HttpGet("to_switch_on")]
        public bool switch_on()
        {
            return st.switch_on();
        }

        [HttpGet("to_swtch_off")]
        public bool switch_off()
        {
            return st.switch_off();
        }

        [HttpGet("to_waiting")]
        public bool wait()
        {
            return st.to_waiting();
        }
    }
}
