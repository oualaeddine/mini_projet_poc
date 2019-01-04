using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HumansLib;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceStudentsCRUD" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceStudentsCRUD.svc ou ServiceStudentsCRUD.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceStudentsCRUD : IServiceStudentsCRUD
    {
        public LinkedList<Student> getAll()
        {
            throw new NotImplementedException();
        }

        public Student getById(string id)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Student> find(Student ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool add(Student ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool edit(Student student)
        {
            throw new NotImplementedException();
        }

        public bool delete(Student ouvrage)
        {
            throw new NotImplementedException();
        }
    }
}
