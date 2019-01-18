using HumansLib;
using HumansLib.profs;
using OuveragesLib;

namespace BiblioLib
{
    public interface IUsersOper
    {
        bool preter(Ouvrage ouvrage, Prof prof);
        bool preter(Ouvrage ouvrage, Student student);
        bool preter(Reservation reservation);
        bool recuperer(Ouvrage ouvrage);
        bool preter(int idOuvrage, int idMembreRes);
    }
}