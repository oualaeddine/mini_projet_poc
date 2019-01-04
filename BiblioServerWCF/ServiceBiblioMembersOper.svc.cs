using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioServerWCF.work;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using static System.Int32;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceBiblioMembersOper" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceBiblioMembersOper.svc ou ServiceBiblioMembersOper.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
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