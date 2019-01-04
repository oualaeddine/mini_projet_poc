using BiblioServerWCF.work;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using static System.Int32;

namespace BiblioServerWCF
{
    public class ServiceBiblioMembersOper : IServiceBiblioMembersOper
    {
        public bool reserver(string type, string userId, string ouvrageId)
        {
            var membersOper = new MembersOperImpl();
            switch (type)
            {
                case "student":
                {
                    var student = new Student {id = Parse(userId)};

                    var ouvrage = new Ouvrage {id = Parse(ouvrageId)};

                    return membersOper.reserver(student, ouvrage);
                }
                case "prof":
                {
                    var prof = new Prof {id = Parse(userId)};

                    var ouvrage = new Ouvrage {id = Parse(ouvrageId)};

                    return membersOper.reserver(prof, ouvrage);
                }
                default:
                {
                    return false;
                }
            }
        }
    }
}