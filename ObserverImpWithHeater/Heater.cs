/******************************************************************
** auth: Frank
** date: 12/5/2017 2:41:11 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpWithHeater
{
    public class Heater
    {
        public event EventHandler BoiledEventHandler;
        public readonly string area = @"Made in China";
        public Heater()
        { }

        public void BoiledWater()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i > 99)
                {
                    int temperature = i;
                    BoiledEventArgs args = new BoiledEventArgs(temperature);
                    Boiled(args);
                }
            }
        }

        private void Boiled(BoiledEventArgs args){
            OnBoiled(args);
        }

        public virtual void OnBoiled(BoiledEventArgs args)
        {
            BoiledEventHandler(this, args);
        }
    }
}
