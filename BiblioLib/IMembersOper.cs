using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioLib
{
    interface IMembersOper
    {
        bool reserver(Prof prof, Ouvrage ouvrage);
        bool reserver(Student student, Ouvrage ouvrage);
        bool subscribe(Prof prof, Ouvrage ouvrage);
        bool subscribe(Student student, Ouvrage ouvrage);
        LinkedList<Ouvrage> find(Ouvrage ouvrage);
    }
}
