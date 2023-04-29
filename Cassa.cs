using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observ
{
    class Cassa: IObserv// представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта. 
    {                  //регистрируется как наблюдатель объекта "Stock"
        public string Name { get; set;}
        IAction stock;
        public Cassa(string name, IAction update)
        {
            this.Name = name;
            stock = update; // обновление информации
            stock.RegisterObserver(this); 
        }
        public void Update(object obnov)
        {
            StockInfo sInfo = (StockInfo)obnov;

            if (sInfo.Ticket > 0)
                Console.WriteLine("Касса {0} продает билеты; Цена билетов: {1}", this.Name, sInfo.Price);
            else
                Console.WriteLine("Касса {0} закрылась ;  Цена билетов: {1}", this.Name, sInfo.OffPrice);
        }
    }
}
