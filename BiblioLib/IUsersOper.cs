using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioLib
{
    public interface IUsersOper
    {
        bool preter(Ouvrage ouvrage, Prof prof);
        bool preter(Ouvrage ouvrage, Student student);
        bool preter(Reservation reservation);
        bool recuperer(Ouvrage ouvrage);
    }
}