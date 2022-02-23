using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImitationModeling18
{
    interface Agent
    {

         
        double NextEventTime(double t);
        void processEvent(double t);
    }
}
