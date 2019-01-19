using System;
using System.Collections.Generic;
using OuveragesLib;
using OuvragesDAL;

namespace BiblioLib.work
{
    public class MembersOperImpl : MarshalByRefObject, IMembersOper
    {
        public LinkedList<Ouvrage> find(string search)
        {
            return new OuvrageDAO().find(search);
        }

        public bool reserver(int idMember, int ouvrageId)
        {
            var dao = new OuvrageDAO();
            bool reserved = dao.reserver(idMember, ouvrageId);

            if (reserved && dao.isDispo(ouvrageId))
            {
                new OuvragesOpsEventsHandelers().ouvrageLibreEvent(ouvrageId);
            }

            return reserved;
        }
    }
}