using System;
using System.Collections.Generic;
using HumansLib;

namespace HumansCRUD
{
    public class StudentsCRUD : MarshalByRefObject, IStudentCRUD
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

        public LinkedList<Student> find(string obj)
        {
            return new StudentsDAO().find(obj);
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

        public Student findOne(string search)
        {
            return new StudentsDAO().findOne(search);
        }

        public bool isSuspended(Student member)
        {
            return new StudentsDAO().isSuspended(member.id);
        }
    }
}