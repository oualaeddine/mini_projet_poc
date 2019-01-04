using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HumansLib.profs;

namespace BiblioServerWCF
{
    public class ServiceProfsCRUD : IServiceProfsCRUD
    {
        public bool add(Prof prof)
        {
            ProfCRUD crud = new ProfCRUD();
            return crud.insert(prof);
        }

        public bool delete(Prof prof)
        {
            ProfCRUD crud = new ProfCRUD();
            return crud.delete(prof);
        }

        public bool edit(Prof prof)
        {
            ProfCRUD crud = new ProfCRUD();
            return crud.update(prof);
        }

        public LinkedList<Prof> find(Prof prof)
        {
            ProfCRUD crud = new ProfCRUD();

            return crud.find(prof);
        }

        public LinkedList<Prof> getAll()
        {
            ProfCRUD crud = new ProfCRUD();
            return crud.getAll();
        }

        public Prof getById(string id)
        {
            ProfCRUD crud = new ProfCRUD();
            return (Prof) crud.getById(Int32.Parse(id));
        }
    }
}