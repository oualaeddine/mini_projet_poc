using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using HumansLib.profs;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceBiblioAdminOper" à la fois dans le code et le fichier de configuration.
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