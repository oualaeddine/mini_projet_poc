using System;
using System.Collections.Generic;
using OuveragesLib;
using OuvragesDAL;

namespace OuvragesCRUD
{
    public class OuvragesCRUDO : MarshalByRefObject, IOuvrageDAO
    {
        OuvrageDAO dao;

        public OuvragesCRUDO()
        {
            dao = new OuvrageDAO();
        }

        public bool delete(int obj)
        {
            return dao.delete(obj);
        }

        public LinkedList<Ouvrage> find(string obj)
        {
            throw new System.NotImplementedException();
        }

        public LinkedList<Ouvrage> find(object obj)
        {
            return null;
            //todo  LinkedList<Ouvrage> find(object obj)
        }

        public LinkedList<Ouvrage> getAll()
        {
            return dao.getAll();
        }

        public Ouvrage getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(Ouvrage obj)
        {
            var ouvrage = (Ouvrage) obj;

            return dao.insert(ouvrage);
        }

        public bool update(Ouvrage obj)
        {
            var ouvrage = (Ouvrage) obj;

            return dao.edit(ouvrage);
        }
    }
}