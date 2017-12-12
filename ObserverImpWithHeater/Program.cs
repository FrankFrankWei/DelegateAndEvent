using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpWithHeater
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            Display display = new Display();

            heater.BoiledEventHandler += alarm.MakeAlert;
            heater.BoiledEventHandler += display.ShowMsg;

            heater.BoiledWater();

            Console.ReadKey();
        }
    }
}
