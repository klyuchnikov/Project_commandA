using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConsoleApplication1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceData" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceData
    {
        [OperationContract]
        void DoWork();
    }
}
