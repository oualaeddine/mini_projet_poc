using System;
using System.Collections.Generic;
using HumansLib;

namespace HumansCRUD
{
    public class UsersCRUD : MarshalByRefObject, IUsersCRUD
    {
        UsersDAO dao;

        public UsersCRUD()
        {
            dao = new UsersDAO();
        }

        public bool delete(User obj)
        {
            User user = (User) obj;
            return dao.delete(user);
        }

        public LinkedList<User> find(User obj)
        {
            return null;
        }

        public LinkedList<User> getAll()
        {
            return dao.getAll();
        }

        public User getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(User obj)
        {
            User user = (User) obj;
            return dao.insert(user);
        }

        public bool update(User obj)
        {
            User user = (User) obj;
            return dao.edit(user);
        }
    }
}