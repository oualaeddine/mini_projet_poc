using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HumansLib.profs;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceProfsCRUD" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceProfsCRUD.svc ou ServiceProfsCRUD.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceProfsCRUD : IServiceProfsCRUD
    {
  public LinkedList<Prof> getAll()
        {
            throw new NotImplementedException();
        }

        public Prof getById(string id)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Prof> find(Prof ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool add(Prof ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool edit(Prof ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool delete(Prof ouvrage)
        {
            throw new NotImplementedException();
        }
    }
}
