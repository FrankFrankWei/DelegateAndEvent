/******************************************************************
** auth: Frank
** date: 12/6/2017 5:43:07 PM
** desc:
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImpByInterface
{
    // register, unregister and notify methods are common for other subjects that implement IObservale interface
    // that's why create a subjectbase class here
    public abstract class SubjectBase : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public SubjectBase()
        { }

        protected virtual void Notify(IObservable sender)
        {
            foreach (var observer in observers)
            {
                observer.Update(sender);
            }
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
