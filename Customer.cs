using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observ
{
    class Customer: IObserv//реализует интерфейс "IObserv" и регистрируется как наблюдатель объекта "Stock"
    {
        public string Name { get; set; }
        IAction stock;
        public Customer(string name, IAction regist)
        {
            this.Name = name;
            stock = regist;
            stock.RegisterObserver(this);
        }
        public void Update(object upd)
        {
            StockInfo sInfo = (StockInfo)upd;

            if ((sInfo.Price < 30) && (sInfo.Ticket>0 ))
                Console.WriteLine("Покупатель {0} покупает билеты;  Стоимость билетов: {1}", this.Name, sInfo.Price);
            else
                Console.WriteLine("Покупатель {0} не покупает билеты;  Стоимость билетов: {1}", this.Name, sInfo.OffPrice);
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);

            stock = null;
        }
    }
}
