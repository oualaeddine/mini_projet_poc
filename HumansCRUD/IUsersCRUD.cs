using System.Collections.Generic;

namespace HumansCRUD
{
    public interface IUsersCRUD
    {
        bool delete(object obj);

        LinkedList<object> find(object obj);

        LinkedList<object> getAll();

        object getById(int id);

        bool insert(object obj);


        bool update(object obj);
    }
}