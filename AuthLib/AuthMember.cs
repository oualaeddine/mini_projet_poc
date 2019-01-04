using HumansLib;
using HumansLib.profs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthLib
{
    public class AuthMember
    {
        public AuthMember()
        {
        }

        public bool login(Student student, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            return new StudentsDAO().exists(student, password);
        }

        public bool login(Prof prof, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            return new ProfDAO().exists(prof, password);
        }

        private bool validate(string password)
        {
            throw new NotImplementedException(); //todo bool validate(string password)
        }

        public bool changePassword(Student student, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            StudentsDAO dao = new StudentsDAO();
            student = (Student) dao.getByID(student.id);
            return dao.edit(student);
        }

        public bool changePassword(Prof prof, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            ProfDAO dao = new ProfDAO();
            prof = (Prof) dao.getByID(prof.id);
            return dao.edit(prof);
        }
    }
}