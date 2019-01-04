using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace HumansLib
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
            Student student = (Student) obj;
            return dao.delete(student);
        }

        public LinkedList<Student> find(Student obj)
        {
            throw new NotImplementedException();//todo LinkedList<Student> find(Student obj)
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
            Student student = (Student) obj;
            return dao.insert(student);
        }

        public bool update(Student obj)
        {
            Student student = (Student) obj;
            return dao.edit(student);
        }
    }
}