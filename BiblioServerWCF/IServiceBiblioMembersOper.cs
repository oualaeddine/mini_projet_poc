using System.ServiceModel;
using System.ServiceModel.Web;

namespace BiblioServerWCF
{
    [ServiceContract]
    public interface IServiceBiblioMembersOper
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "reserver", ResponseFormat = WebMessageFormat.Json)]
        bool reserver(string type, string userId, string ouvrageId);
    }
}