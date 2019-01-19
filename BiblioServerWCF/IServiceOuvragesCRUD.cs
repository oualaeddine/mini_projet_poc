using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using OuveragesLib;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceOuvragesCRUD" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceOuvragesCRUD
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Ouvrage> getAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getById/{id}", ResponseFormat = WebMessageFormat.Json)]
        Ouvrage getById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "find", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Ouvrage> find(string ouvrage);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "add", ResponseFormat = WebMessageFormat.Json)]
        bool add(Ouvrage ouvrage);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json)]
        bool edit(Ouvrage ouvrage);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json)]
        bool delete(Ouvrage ouvrage);
    }
}