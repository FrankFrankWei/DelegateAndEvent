/******************************************************************
** auth: Frank
** date: 11/30/2017 10:18:11 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscriber
{
    public class Subscriber
    {
        public Subscriber()
        { }

        public void OnNumberChanged(int number)
        {
            Console.WriteLine("notified from publisher, now number is : " + number);
        }
    }
}
