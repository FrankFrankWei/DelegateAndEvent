/******************************************************************
** auth: Frank
** date: 11/30/2017 6:47:47 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByInterface
{
    public class GreetingManager
    {
        public GreetingManager()
        { }

        public void MakeGreeting(string name, IGreeting greeting)
        {
            greeting.GreetingPeople(name);
        }
    }
}
