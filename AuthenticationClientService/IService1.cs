using System.ServiceModel;

namespace AuthenticationClientService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string AuthenticateUser(string username, string password);
    }
}

