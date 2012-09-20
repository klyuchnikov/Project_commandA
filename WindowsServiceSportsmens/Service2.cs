using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WindowsServiceSportsmens
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service2" в коде и файле конфигурации.
    public class Service2 : IService2
    {
        public void DoWork()
        {
        }


        public int getFive()
        {
            return 5;
        }
    }
}
