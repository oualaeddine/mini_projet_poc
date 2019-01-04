using HumansLib;
using HumansLib.profs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioLib
{
    public interface ISystemOper
    {
        bool banMember(Student student);
        bool banMember(Prof prof);
        bool sendNotif(Student student);
        bool sendNotif(Prof prof);
    }
}
