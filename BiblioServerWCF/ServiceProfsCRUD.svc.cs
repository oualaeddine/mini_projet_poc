using System.Collections.Generic;
using HumansCRUD;
using HumansLib.profs;

namespace BiblioServerWCF
{
    public class ServiceProfsCRUD : IServiceProfsCRUD
    {
        public bool add(Prof prof)
        {
            var crud = new ProfCRUD();
            return crud.insert(prof);
        }

        public bool delete(Prof prof)
        {
            var crud = new ProfCRUD();
            return crud.delete(prof);
        }

        public bool edit(Prof prof)
        {
            var crud = new ProfCRUD();
            return crud.update(prof);
        }

        public LinkedList<Prof> find(string prof)
        {
            var crud = new ProfCRUD();

            return crud.find(prof);
        }

        public LinkedList<Prof> getAll()
        {
            var crud = new ProfCRUD();
            return crud.getAll();
        }

        public Prof getById(string id)
        {
            var crud = new ProfCRUD();
            return (Prof) crud.getById(int.Parse(id));
        }
    }
}