using BiblioLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;

namespace BiblioServerWCF.work
{
    public class MembersOperImpl : IMembersOper
    {
        public LinkedList<Ouvrage> find(Ouvrage ouvrage)
        {
            throw new NotImplementedException();//todo  find(Ouvrage ouvrage)
        }

        public bool reserver(Student student, Ouvrage ouvrage)
        {
            throw new NotImplementedException();//todo reserver(Student student, Ouvrage ouvrage)
        }

        public bool reserver(Prof prof, Ouvrage ouvrage)
        {
            throw new NotImplementedException();//todo reserver(Prof prof, Ouvrage ouvrage)
        }

        public bool subscribe(Student student, Ouvrage ouvrage)
        {
            throw new NotImplementedException();//todo subscribe(Student student, Ouvrage ouvrage)
        }

        public bool subscribe(Prof prof, Ouvrage ouvrage)
        {
            throw new NotImplementedException();//todo subscribe(Prof prof, Ouvrage ouvrage)
        }
    }
}