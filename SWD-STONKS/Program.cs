using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace SWD_STONKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

   public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Detach(IObserver observer);
        public void Notify();
    }

   public interface IObserver
   {
       public void Update(ISubject subject);
   }

   public class Portfolio :IObserver
   {

   }
}
