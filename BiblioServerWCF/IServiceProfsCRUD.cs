using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using HumansLib.profs;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceProfsCRUD" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceProfsCRUD
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Prof> getAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getById/{id}", ResponseFormat = WebMessageFormat.Json)]
        Prof getById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "find", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Prof> find(Prof ouvrage);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "add", ResponseFormat = WebMessageFormat.Json)]
        bool add(Prof ouvrage);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json)]
        bool edit(Prof ouvrage);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json)]
        bool delete(Prof ouvrage);

    }
}
