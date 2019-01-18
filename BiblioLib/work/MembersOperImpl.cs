using System.Collections.Generic;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;

namespace BiblioLib.work
{
    public class MembersOperImpl : IMembersOper
    {
        public LinkedList<Ouvrage> find(Ouvrage ouvrage)
        {
            return null;
            //todo  find(Ouvrage ouvrage)
        }

        public void reserver(int idMember, int ouvrage)
        {
            throw new System.NotImplementedException();
        }

        public bool reserver(Student student, Ouvrage ouvrage)
        {
            return false;
//todo reserver(Student student, Ouvrage ouvrage)
        }

        public bool reserver(Prof prof, Ouvrage ouvrage)
        {
            return false;
//todo reserver(Prof prof, Ouvrage ouvrage)
        }

        public bool subscribe(Student student, Ouvrage ouvrage)
        {
            return false;
//todo subscribe(Student student, Ouvrage ouvrage)
        }

        public bool subscribe(Prof prof, Ouvrage ouvrage)
        {
            return false;
//todo subscribe(Prof prof, Ouvrage ouvrage)
        }
    }
}