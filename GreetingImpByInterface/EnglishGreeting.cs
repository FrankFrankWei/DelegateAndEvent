/******************************************************************
** auth: Frank
** date: 11/30/2017 6:44:07 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByInterface
{
    public class EnglishGreeting : IGreeting
    {
        public EnglishGreeting()
        { }

        public void GreetingPeople(string name)
        {
            Console.WriteLine(string.Format(@"Hello {0}", name));
        }
    }
}
