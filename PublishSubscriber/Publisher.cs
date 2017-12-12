/******************************************************************
** auth: Frank
** date: 11/30/2017 10:14:59 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscriber
{
    public delegate void NumberChangeEventHandler(int number);
    public class Publisher
    {
        public event NumberChangeEventHandler numberChanged;
        public Publisher()
        { }

        public void Counting()
        {
            int i = 0;
            while (i < 100)
            {
                i++;

                if (99 == i && null != numberChanged)
                    numberChanged.BeginInvoke(i, null, null);
            };
        }
    }
}
