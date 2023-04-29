using System;
using System.Collections.Generic;


namespace Observ
{
    class Stock:IAction//реализация интерфейса IAction
    {
        StockInfo sInfo;

        List<IObserv> observers;
        public Stock()
        {
            observers = new List<IObserv>();
            sInfo = new StockInfo();
        }
        public void RegisterObserver(IObserv attention)
        {
            observers.Add(attention);
        }

        public void RemoveObserver(IObserv attention)
        {
            observers.Remove(attention);
        }

        public void NotifyObservers()
        {
            foreach (IObserv attention in observers)
            {
                attention.Update(sInfo);
            }
        }
        public void Change()//изменяет цену и количество доступных билетов
        {
            Random rnd = new Random();
            sInfo.Price = rnd.Next(20, 40);
            sInfo.Ticket = rnd.Next(0, 50);
            NotifyObservers(); //уведомление об изменении
        }
    }
}
