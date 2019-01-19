using HumansLib;
using HumansLib.profs;

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
            return password.Length > 6;
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