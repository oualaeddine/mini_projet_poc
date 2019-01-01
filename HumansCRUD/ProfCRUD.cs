using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace HumansLib.profs
{
    class ProfCRUD : ICRUD
    {
        ProfDAO dao;
        public ProfCRUD()
        {
            dao = new ProfDAO();
        }
        public bool delete(object obj)
        {
            Prof prof = (Prof)obj;
            return dao.delete(prof);
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
            Prof prof = (Prof)obj;
            return dao.insert(prof);
        }

        public bool update(object obj)
        {
            Prof prof = (Prof)obj;
            return dao.edit(prof);
        }
    }
}
