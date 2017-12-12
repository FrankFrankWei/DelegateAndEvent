/******************************************************************
** auth: Frank
** date: 12/6/2017 5:38:17 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    public class Heater : SubjectBase
    {
        public string Area { private set; get; }
        public int Temperature { private set; get; }
        public Heater()
        {
            Area = @"Made in China";
        }

        public void BoiledWater()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i > 97)
                {
                    Temperature = i;
                    OnBoiled();
                }
            }
        }

        //for subclass override if needed
        protected virtual void OnBoiled()
        {
            base.Notify(this);
        }
    }
}
