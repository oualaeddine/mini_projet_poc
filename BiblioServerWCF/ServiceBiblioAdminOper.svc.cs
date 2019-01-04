using System;
using BiblioServerWCF.work;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using static System.Int32;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceBiblioAdminOper" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceBiblioAdminOper.svc ou ServiceBiblioAdminOper.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
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