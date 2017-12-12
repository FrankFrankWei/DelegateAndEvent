/******************************************************************
** auth: Frank
** date: 11/30/2017 6:45:38 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByInterface
{
    public class ChineseGreeting : IGreeting
    {
        public ChineseGreeting()
        { }

        public void GreetingPeople(string name)
        {
            Console.WriteLine(string.Format(@"你好 {0}", name));
        }
    }
}
