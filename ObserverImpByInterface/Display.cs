/******************************************************************
** auth: Frank
** date: 12/6/2017 6:11:51 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    public class Display : IObserver
    {
        public Display()
        { }

        public void Update(IObservable sender)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("Display: heater " + heater.Area + " , now temperature is : " + heater.Temperature);
        }
    }
}
