using HumansLib;
using HumansLib.profs;

namespace BiblioLib.work
{
    public class SysOperImpl : ISystemOper
    {
        public bool banMember(Prof prof)
        {
            return new ProfDAO().ban(prof);
        }

        public bool banMember(Student student)
        {
            return new StudentsDAO().ban(student);
        }

        public bool sendNotif(Prof prof)
        {
            return false;
//todo sendNotif(Prof prof)
        }

        public bool sendNotif(Student student)
        {
            return false;
//todo sendNotif(Student student)
        }
    }
}