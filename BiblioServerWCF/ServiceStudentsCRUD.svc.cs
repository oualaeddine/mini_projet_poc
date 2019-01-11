using System.Collections.Generic;
using HumansCRUD;
using HumansLib;

namespace BiblioServerWCF
{
    public class ServiceStudentsCRUD : IServiceStudentsCRUD
    {
        public bool add(Student student)
        {
            var crud = new StudentsCRUD();
            return crud.insert(student);
        }

        public bool delete(Student student)
        {
            var crud = new StudentsCRUD();
            return crud.delete(student);
        }

        public bool edit(Student student)
        {
            var crud = new StudentsCRUD();
            return crud.update(student);
        }

        public LinkedList<Student> find(Student student)
        {
            var crud = new StudentsCRUD();

            return crud.find(student);
        }

        public LinkedList<Student> getAll()
        {
            var crud = new StudentsCRUD();
            return crud.getAll();
        }

        public Student getById(string id)
        {
            var crud = new StudentsCRUD();
            return crud.getById(int.Parse(id));
        }
    }
}