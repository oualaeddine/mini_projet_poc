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
            throw new NotImplementedException();
        }

        public bool reserver(Student student, Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool reserver(Prof prof, Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool subscribe(Student student, Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool subscribe(Prof prof, Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }
    }
}