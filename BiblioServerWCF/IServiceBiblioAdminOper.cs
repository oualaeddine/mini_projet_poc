using System.ServiceModel;
using System.ServiceModel.Web;

namespace BiblioServerWCF
{
    [ServiceContract]
    public interface IServiceBiblioAdminOper
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "rendre", ResponseFormat = WebMessageFormat.Json)]
        bool rendre(string ouvrageId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "preter", ResponseFormat = WebMessageFormat.Json)]
        bool preter(string type, string id, string ouvrageId);
    }
}