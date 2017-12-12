/******************************************************************
** auth: Frank
** date: 12/6/2017 6:08:47 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    public class Alarm : IObserver
    {
        public Alarm()
        { }

        public void Update(IObservable sender)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("Alarm: heater " + heater.Area + " , now temperature is : " + heater.Temperature);
        }
    }
}
