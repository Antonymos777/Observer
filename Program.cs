using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observ
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Cassa cassa = new Cassa ("Театральная", stock);
            Customer customer = new Customer("Павел", stock);
            //обменник
            stock.Change();
            // прекращает наблюдать за покупкой
            customer.StopTrade();
            // имитация покупок
            stock.Change();
          
            Console.Read();
        }
    }
}
