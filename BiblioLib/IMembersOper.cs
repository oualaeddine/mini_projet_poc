using System.Collections.Generic;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;

namespace BiblioLib
{
    public interface IMembersOper
    {
        bool reserver(Prof prof, Ouvrage ouvrage);
        bool reserver(Student student, Ouvrage ouvrage);
        bool subscribe(Prof prof, Ouvrage ouvrage);
        bool subscribe(Student student, Ouvrage ouvrage);
        LinkedList<Ouvrage> find(Ouvrage ouvrage);
        void reserver(int idMember, int ouvrage);
    }
}