using HumansLib;
using HumansLib.profs;
using OuveragesLib;

namespace BiblioLib.work
{
    public class UsersOperImpl : IUsersOper
    {
        public bool preter(Ouvrage ouvrage, Prof prof)
        {
            return false;
            //todo  preter(Ouvrage ouvrage, Prof prof)
        }

        public bool preter(Ouvrage ouvrage, Student student)
        {
            return false;
            //todo  preter(Ouvrage ouvrage, Student student)
        }

        public bool preter(Reservation reservation)
        {
            return false;
            //todo  preter(Reservation reservation)
        }

        public bool recuperer(Ouvrage ouvrage)
        {
            return false;
            //todo  recuperer(Ouvrage ouvrage)
        }

        public bool preter(int idOuvrage, int idMembreRes)
        {
            throw new System.NotImplementedException();
        }
    }
}