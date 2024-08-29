using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;


namespace AuthenticationServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAuthenticationServer
    {

        [OperationContract]
        Task<AccessTokenResponse> GetAccessToken(string username, string password);

    }

    [DataContract]
    public class AccessTokenResponse
    {
        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public string Message { get; set; }
    }


}
