using System.Collections.Generic;
using HumansLib;

namespace HumansCRUD
{
    public interface IUsersCRUD
    {
        bool delete(User obj);

        LinkedList<User> find(User obj);

        LinkedList<User> getAll();

        User getById(int id);

        bool insert(User obj);


        bool update(User obj);
    }
}