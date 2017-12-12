/******************************************************************
** auth: Frank
** date: 12/6/2017 12:37:48 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpWithHeater
{
    public class Display
    {
        public Display()
        { }

        public void ShowMsg(Object sender, EventArgs args)
        {
            Heater heater = (Heater)sender;
            BoiledEventArgs boiledEventArgs = (BoiledEventArgs)args;
            Console.WriteLine("Display - area: " + heater.area + " temperature now is: " + boiledEventArgs.temperature);
        }
    }
}
