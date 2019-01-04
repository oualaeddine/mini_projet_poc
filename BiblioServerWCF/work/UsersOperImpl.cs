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
    public class UsersOperImpl : IUsersOper
    {
        public bool preter(Reservation reservation, User user)
        {
            throw new NotImplementedException();
        }

        public bool preter(Ouvrage ouvrage, Student student, User user)
        {
            throw new NotImplementedException();
        }

        public bool preter(Ouvrage ouvrage, Prof prof, User user)
        {
            throw new NotImplementedException();
        }

        public bool recuperer(Ouvrage ouvrage, User user)
        {
            throw new NotImplementedException();
        }
    }
}