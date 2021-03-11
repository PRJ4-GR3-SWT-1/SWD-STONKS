using System.Collections.Generic;

namespace SWD_STONKS
{
    public abstract class StockSubject
    {
        private ICollection<IObserver> observers = new List<IObserver>();


        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

    }
}