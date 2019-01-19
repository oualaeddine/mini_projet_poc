using HumansLib;
using HumansLib.profs;

namespace BiblioLib
{
    public interface ISystemOper
    {
        bool banMember(Student student);
        bool banMember(Prof prof);
        bool sendNotif(Human member, int ouvrageId);
    }
}