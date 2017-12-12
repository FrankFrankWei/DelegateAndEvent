/******************************************************************
** auth: Frank
** date: 12/6/2017 5:36:27 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    public interface IObserver
    {
        void Update(IObservable sender);
    }
}
