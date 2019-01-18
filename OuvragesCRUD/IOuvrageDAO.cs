using System.Collections.Generic;
using OuveragesLib;

namespace OuvragesCRUD
{
    public interface IOuvrageDAO
    {
        bool delete(object obj);

        LinkedList<Ouvrage> find(string obj);

        LinkedList<Ouvrage> getAll();
        Ouvrage getById(int id);

        bool insert(object obj);

        bool update(object obj);
    }
}