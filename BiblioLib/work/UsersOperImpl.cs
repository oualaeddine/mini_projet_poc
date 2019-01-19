using System;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using OuvragesDAL;

namespace BiblioLib.work
{
    public class UsersOperImpl : MarshalByRefObject, IUsersOper
    {
        public bool preter(Ouvrage ouvrage, Prof prof)
        {
            return preter(ouvrage.id, prof.id);
        }

        public bool preter(Ouvrage ouvrage, Student student)
        {
            return preter(ouvrage.id, student.id);
        }

        public bool preter(Reservation reservation)
        {
            return preter(reservation.ouvrage.id, reservation.member.id);
        }

        public bool recuperer(Ouvrage ouvrage)
        {
            bool recup = new OuvrageDAO().deleteEmprunt(ouvrage);
            if (recup)
            {
                new OuvragesOpsEventsHandelers().ouvrageLibreEvent(ouvrage.id);
            }

            return recup;
        }

        public bool preter(int idOuvrage, int idMembre)
        {
            return new OuvrageDAO().insertPret(idOuvrage, idMembre);
        }
    }
}