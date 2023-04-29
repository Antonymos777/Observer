using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observ
{
    interface IAction // определяет методы,которые должны быть реализованы объектом-издателем, чтобы наблюдатели могли зарегистрироваться,
                      // отписаться и получать уведомления. 
    {
        void RegisterObserver(IObserv o);
        void RemoveObserver(IObserv o);
        void NotifyObservers();
    }
}

