/******************************************************************
** auth: Frank
** date: 12/6/2017 5:35:43 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);

    }
}
