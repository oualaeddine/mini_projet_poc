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
        public bool add(Student student)
        {
            StudentsCRUD crud = new StudentsCRUD();
            return crud.insert(student);
        }

        public bool delete(Student student)
        {
            StudentsCRUD crud = new StudentsCRUD();
            return crud.delete(student);
        }

        public bool edit(Student student)
        {
            StudentsCRUD crud = new StudentsCRUD();
            return crud.update(student);
        }

        public LinkedList<Student> find(Student student)
        {
            StudentsCRUD crud = new StudentsCRUD();

            return crud.find(student);
        }

        public LinkedList<Student> getAll()
        {
            StudentsCRUD crud = new StudentsCRUD();
            return crud.getAll();
        }

        public Student getById(string id)
        {
            StudentsCRUD crud = new StudentsCRUD();
            return (Student)crud.getById(Int32.Parse(id));
        }
    }
}
