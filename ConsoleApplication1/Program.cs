using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceDataClient client = new ServiceDataClient();
          //  client.Auth("", "");
            
         //   MembershipCreateStatus status;
          //  var res = client.AddUser(out status, "дмитрий", "qwe", "qwe", DateTime.Now, "dmitry", "dmitry");
            var res = client.GetAllScales();
            Console.ReadKey();
        }
    }
}