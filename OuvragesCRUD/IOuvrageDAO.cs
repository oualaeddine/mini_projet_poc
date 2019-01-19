using System.Collections.Generic;
using OuveragesLib;

namespace OuvragesCRUD
{
    public interface IOuvrageDAO
    {
        bool delete(int obj);

        LinkedList<Ouvrage> find(string obj);

        LinkedList<Ouvrage> getAll();
        Ouvrage getById(int id);

        bool insert(Ouvrage obj);

        bool update(Ouvrage obj);
    }
}