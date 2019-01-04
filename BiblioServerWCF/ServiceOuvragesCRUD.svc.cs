using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OuveragesLib;
using OuvragesCRUD;

namespace BiblioServerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceOuvragesCRUD" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceOuvragesCRUD.svc ou ServiceOuvragesCRUD.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceOuvragesCRUD : IServiceOuvragesCRUD
    {
        public bool add(Ouvrage ouvrage)
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();
            return crud.insert(ouvrage);
        }

        public bool delete(Ouvrage ouvrage)
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();
            return crud.delete(ouvrage);
        }

        public bool edit(Ouvrage ouvrage)
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();
            return crud.update(ouvrage);
        }

        public LinkedList<Ouvrage> find(Ouvrage ouvrage)
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();

            return crud.find(ouvrage);
        }

        public LinkedList<Ouvrage> getAll()
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();
            return crud.getAll();
        }

        public Ouvrage getById(string id)
        {
            OuvragesCRUDO crud = new OuvragesCRUDO();
            return (Ouvrage)crud.getById(Int32.Parse(id));
        }
    }
}
