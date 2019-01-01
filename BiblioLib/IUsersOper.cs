using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioLib
{
    interface IUsersOper
    {
        bool preter(Ouvrage ouvrage, Prof prof, User user);
        bool preter(Ouvrage ouvrage, Student student, User user);
        bool preter(Reservation reservation, User user);
        bool recuperer(Ouvrage ouvrage, User user);
    }
}
