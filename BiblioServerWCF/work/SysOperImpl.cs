using BiblioLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumansLib;
using HumansLib.profs;

namespace BiblioServerWCF.work
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
            throw new NotImplementedException();
        }

        public bool sendNotif(Student student)
        {
            throw new NotImplementedException();
        }
    }
}