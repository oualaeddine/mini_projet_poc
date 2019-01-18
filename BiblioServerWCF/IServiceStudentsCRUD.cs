using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using HumansLib;

namespace BiblioServerWCF
{
    [ServiceContract]
    public interface IServiceStudentsCRUD
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Student> getAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getById/{id}", ResponseFormat = WebMessageFormat.Json)]
        Student getById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "find", ResponseFormat = WebMessageFormat.Json)]
        LinkedList<Student> find(string ouvrage);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "add", ResponseFormat = WebMessageFormat.Json)]
        bool add(Student ouvrage);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json)]
        bool edit(Student student);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json)]
        bool delete(Student ouvrage);
    }
}