using System.ServiceModel;
using System.ServiceModel.Web;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceBiblioMembersOper" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceBiblioMembersOper
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "reserver", ResponseFormat = WebMessageFormat.Json)]
        bool reserver(string type, string userId, string ouvrageId);
    }
}