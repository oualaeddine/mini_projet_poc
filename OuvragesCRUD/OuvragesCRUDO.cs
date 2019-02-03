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
            return new OuvrageDAO().find(obj);
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

        public bool isOuvrageDispoForUser(int idOuvrage, int humanId)
        {
            return new OuvrageDAO().isDispoForMember(idOuvrage, humanId);
            
        }
    }
}