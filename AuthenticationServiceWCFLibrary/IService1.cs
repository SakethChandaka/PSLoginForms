using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static AuthenticationServiceWCFLibrary.Service;

namespace AuthenticationServiceWCFLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract(Name = "AuthenticateUserByPassword")]
        AuthenticationResponse AuthenticateUser(string username, string password);

        [OperationContract(Name = "AuthenticateUserByOtp")]
        AuthenticationResponse AuthenticateUserOtp(string username, string otp);

    }

}
