using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            Display display = new Display();

            heater.Register(alarm);
            heater.Register(display);

            heater.BoiledWater();
            Console.ReadKey();
        }
    }
}
