using System.Collections.Generic;
using System.Linq;

namespace SWD_STONKS
{
    public class Stock : ISubject
    {
        private ICollection<IObserver> observers;
        public string Name { get; set; }
        public double Value { get; set; }

        public Stock()
        {
            this.observers = new List<IObserver>();
        }

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
            for (int i = 0; i < observers.Count; i++)
            {
                observers.ElementAt(i).Update(this);
            }
        }
    }
}