using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HumansLib;
using HumansLib.profs;

namespace BiblioServerWCF
{
    [ServiceContract]
    public interface IServiceHumansAuth
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "loginP", ResponseFormat = WebMessageFormat.Json)]
        bool login(string type, string username, string password);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "changePasswordU", ResponseFormat = WebMessageFormat.Json)]
        bool changePassword(string type, string userId, string password);
    }
}