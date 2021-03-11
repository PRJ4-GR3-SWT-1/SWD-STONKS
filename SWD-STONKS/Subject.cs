namespace SWD_STONKS
{
    public abstract class Subject
    {
        public abstract void Attach(IObserver observer);
        public abstract void Detach(IObserver observer);
        public abstract void Notify();
    }
}