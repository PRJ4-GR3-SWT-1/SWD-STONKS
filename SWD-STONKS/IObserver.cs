namespace SWD_STONKS
{
    public interface IObserver
    {
        public void Update(StockSubject subject);
    }
}