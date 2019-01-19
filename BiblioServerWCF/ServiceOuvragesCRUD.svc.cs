using System.Collections.Generic;
using OuveragesLib;
using OuvragesCRUD;

namespace BiblioServerWCF
{
    public class ServiceOuvragesCRUD : IServiceOuvragesCRUD
    {
        public bool add(Ouvrage ouvrage)
        {
            var crud = new OuvragesCRUDO();
            return crud.insert(ouvrage);
        }

        public bool delete(Ouvrage ouvrage)
        {
            var crud = new OuvragesCRUDO();
            return crud.delete(ouvrage.id);
        }

        public bool edit(Ouvrage ouvrage)
        {
            var crud = new OuvragesCRUDO();
            return crud.update(ouvrage);
        }

        public LinkedList<Ouvrage> find(string ouvrage)
        {
            var crud = new OuvragesCRUDO();

            return crud.find(ouvrage);
        }

        public LinkedList<Ouvrage> getAll()
        {
            var crud = new OuvragesCRUDO();
            return crud.getAll();
        }

        public Ouvrage getById(string id)
        {
            var crud = new OuvragesCRUDO();
            return (Ouvrage) crud.getById(int.Parse(id));
        }
    }
}