using System.Collections.Generic;
using HumansLib;

namespace HumansCRUD
{
    public interface IStudentCRUD
    {
        bool delete(Student obj);

        LinkedList<Student> find(string obj);


        LinkedList<Student> getAll();


        Student getById(int id);


        bool insert(Student obj);

        bool update(Student obj);
        Student findOne(string search);
        bool isSuspended(Student member);
    }
}