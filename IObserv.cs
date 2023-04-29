using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observ
{
    interface IObserv// определяет метод "Update", который должен быть реализован наблюдателями для обработки уведомлений.
    {
       
      void Update(Object ob);
        
    }

}

