/******************************************************************
** auth: Frank
** date: 11/30/2017 7:11:17 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByDelegate
{
    public delegate void GreetingDelegate(string name);
    public class GreetingManager
    {
        public event GreetingDelegate greetingDelegate;
        public GreetingManager()
        { }

        public void MakeGreeting(string name)
        {
            greetingDelegate(name);
        }
    }
}
