using OuveragesLib;
using OuvragesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace OuvragesCRUD
{
    public class OuvragesCRUDO : ICRUD
    {
        OuvrageDAO dao;
        public OuvragesCRUDO()
        {
            dao = new OuvrageDAO();
        }
        public bool delete(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;
            return dao.delete(ouvrage);
        }

        public LinkedList<object> find(object obj)
        {
            throw new NotImplementedException();
        }

        public LinkedList<object> getAll()
        {
            return dao.getAll();
        }

        public object getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;

            return dao.insert(ouvrage);
        }

        public bool update(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;

            return dao.edit(ouvrage);
        }
    }
}
