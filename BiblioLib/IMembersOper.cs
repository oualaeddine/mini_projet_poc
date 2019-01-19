using System.Collections.Generic;
using OuveragesLib;

namespace BiblioLib
{
    public interface IMembersOper
    {
        LinkedList<Ouvrage> find(string search);
        bool reserver(int idMember, int ouvrage);
    }
}