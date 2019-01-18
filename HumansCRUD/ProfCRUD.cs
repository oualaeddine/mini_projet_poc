using System.Collections.Generic;
using HumansLib.profs;

namespace HumansCRUD
{
    public class ProfCRUD : IProfCRUD
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
            return null;
            //todo LinkedList<Prof> find(Prof obj)
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
            throw new System.NotImplementedException();
        }

        public bool isSuspended(Prof prof)
        {
            throw new System.NotImplementedException();
        }
    }
}