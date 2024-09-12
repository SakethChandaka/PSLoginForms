using System;
using System.ServiceProcess;

namespace AuthenticationService
{
    internal static class AuthenticationService
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new OAuthService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
