using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace HumansLib
{
    public class StudentsCRUD :ICRUD
    {
        StudentsDAO dao;
        public StudentsCRUD()
        {
            dao = new StudentsDAO();
        }
        public bool delete(object obj)
        {
            Student student = (Student)obj;
            return dao.delete(student);
        }

        public LinkedList<object> find(object obj)
        {
            throw new NotImplementedException();
        }

        public LinkedList<object> getAll()
        {
            return dao.getAll();
        }

        public object getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(object obj)
        {
            Student student = (Student)obj;
            return dao.insert(student);
        }

        public bool update(object obj)
        {
            Student student = (Student)obj;
            return dao.edit(student);
        }
    }
}
