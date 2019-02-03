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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("reserver("+idMember+","+ouvrageId+")");
            Console.BackgroundColor = ConsoleColor.Black;
            
            var dao = new OuvrageDAO();
            bool reserved = dao.reserver(idMember, ouvrageId);

            if (reserved && dao.isDispo(ouvrageId))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("reserved and dispo firing event");
                Console.BackgroundColor = ConsoleColor.Black;

                new OuvragesOpsEventsHandelers().ouvrageLibreEvent(ouvrageId);
            }

            return reserved;
        }
    }
}