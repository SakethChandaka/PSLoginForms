using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace AuthenticationWindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            // Service Information
            serviceInstaller1.ServiceName = "AuthenticationWCFService";
            serviceInstaller1.DisplayName = "Authentication WCF Service";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;

            // Service will run under the Local System account
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
        }

    }
}
