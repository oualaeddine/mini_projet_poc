using System.Collections.Generic;
using HumansLib.profs;

namespace HumansCRUD
{
    public interface IProfCRUD
    {
        bool delete(object obj);

        LinkedList<Prof> find(string obj);

        LinkedList<Prof> getAll();

        Prof getById(int id);

        bool insert(Prof obj);

        bool update(Prof obj);
        Prof findOne(string search);
        bool isSuspended(Prof prof);
    }
}