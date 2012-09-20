using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;

namespace ServiceSportsmens
{
    partial class WinService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public WinService()
        {
            InitializeComponent();
            ServiceName = "WCFServicesSportsmens";
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Добавьте код для запуска службы.
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(ServiceData));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            // TODO: Добавьте код, выполняющий подготовку к остановке службы.
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
