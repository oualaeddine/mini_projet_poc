using System;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using static System.Int32;
using BiblioLib.work;

namespace BiblioServerWCF
{
    public class ServiceBiblioAdminOper : IServiceBiblioAdminOper
    {
        public bool rendre(string ouvrageId)
        {
            var usersOperImpl = new UsersOperImpl();

            var ouvrage = new Ouvrage {id = Parse(ouvrageId)};
            return usersOperImpl.recuperer(ouvrage);
        }


        public bool preter(string type, string memberId, string ouvrageId)
        {
            var usersOperImpl = new UsersOperImpl();
            var ouvrage = new Ouvrage {id = Convert.ToInt32(ouvrageId)};

            switch (type)
            {
                case "prof":
                {
                    var prof = new Prof {id = Convert.ToInt32(memberId)};
                    return usersOperImpl.preter(ouvrage, prof);
                }
                case "student":
                {
                    var student = new Student() {id = Convert.ToInt32(memberId)};
                    return usersOperImpl.preter(ouvrage, student);
                }
                default:
                {
                    return false;
                }
            }
        }
    }
}