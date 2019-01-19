using System;
using System.Collections.Generic;
using HumansLib.profs;

namespace HumansCRUD
{
    public class ProfCRUD : MarshalByRefObject, IProfCRUD
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

        public LinkedList<Prof> find(string obj)
        {
            return new ProfDAO().find(obj);
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
            var prof = obj;
            return dao.insert(prof);
        }

        public bool update(Prof obj)
        {
            var prof = obj;
            return dao.edit(prof);
        }

        public Prof findOne(string search)
        {
            return new ProfDAO().findOne(search);
        }

        public bool isSuspended(Prof prof)
        {
            return new ProfDAO().isSuspended(prof.id);
        }
    }
}