using AuthenticationServiceWCFLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWindowsService
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost _serviceHost = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
            }

            // Define the base address for the WCF service
            Uri baseAddress = new Uri("http://localhost:8080/AuthenticationService");

            // Create a new instance of ServiceHost for the WCF service
            _serviceHost = new ServiceHost(typeof(Service), baseAddress);

            // Open the ServiceHost to start listening for messages
            _serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
                _serviceHost = null;
            }
        }
    }
}
