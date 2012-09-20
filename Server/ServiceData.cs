using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceData" в коде и файле конфигурации.
    public class ServiceData : IServiceData
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
