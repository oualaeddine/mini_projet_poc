using System.Collections.Generic;
using HumansLib;

namespace HumansCRUD
{
    public class StudentsCRUD
    {
        StudentsDAO dao;

        public StudentsCRUD()
        {
            dao = new StudentsDAO();
        }

        public bool delete(Student obj)
        {
            return dao.delete(obj);
        }

        public LinkedList<Student> find(Student obj)
        {
            return null;
            //todo LinkedList<Student> find(Student obj)
        }

        public LinkedList<Student> getAll()
        {
            return dao.getAll();
        }

        public Student getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(Student obj)
        {
            return dao.insert(obj);
        }

        public bool update(Student obj)
        {
            return dao.edit(obj);
        }
    }
}