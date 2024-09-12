using System;
using System.ServiceProcess;
using System.ServiceModel;
using System.Diagnostics;

namespace AuthenticationService
{
    public partial class OAuthService : ServiceBase
    {
        private ServiceHost serviceHost;

        public OAuthService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                // Initialize and start the WCF service
                serviceHost = new ServiceHost(typeof(AuthenticationClientService.Service1));
                serviceHost.Open();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during service start-up
                EventLog.WriteEntry($"Error starting WCF service: {ex.Message}", EventLogEntryType.Error);
                throw;
            }
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
