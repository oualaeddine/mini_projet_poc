using System;
using System.Collections.Generic;

namespace HumansLib.profs
{
    public class ProfCRUD
    {
        ProfDAO dao;

        public ProfCRUD()
        {
            dao = new ProfDAO();
        }

        public bool delete(object obj)
        {
            var prof = (Prof) obj;
            return dao.delete(prof);
        }

        public LinkedList<Prof> find(Prof obj)
        {
            throw new NotImplementedException(); //todo LinkedList<Prof> find(Prof obj)
        }

        public LinkedList<Prof> getAll()
        {
            return dao.getAll();
        }

        public Prof getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(Prof obj)
        {
            var prof = (Prof) obj;
            return dao.insert(prof);
        }

        public bool update(Prof obj)
        {
            var prof = (Prof) obj;
            return dao.edit(prof);
        }
    }
}