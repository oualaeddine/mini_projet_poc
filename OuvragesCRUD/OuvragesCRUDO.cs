using System;
using System.Collections.Generic;
using OuveragesLib;
using OuvragesDAL;

namespace OuvragesCRUD
{
    public class OuvragesCRUDO : IOuvrageDAO
    {
        OuvrageDAO dao;

        public OuvragesCRUDO()
        {
            dao = new OuvrageDAO();
        }

        public bool delete(object obj)
        {
            var ouvrage = (Ouvrage) obj;
            return dao.delete(ouvrage);
        }

        public LinkedList<Ouvrage> find(object obj)
        {
            throw new NotImplementedException(); //todo  LinkedList<Ouvrage> find(object obj)
        }

        public LinkedList<Ouvrage> getAll()
        {
            return dao.getAll();
        }

        public Ouvrage getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(object obj)
        {
            var ouvrage = (Ouvrage) obj;

            return dao.insert(ouvrage);
        }

        public bool update(object obj)
        {
            var ouvrage = (Ouvrage) obj;

            return dao.edit(ouvrage);
        }
    }
}