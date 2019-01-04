using System;
using System.Collections.Generic;

namespace HumansLib
{
    public class UsersCRUD
    {
        UsersDAO dao;

        public UsersCRUD()
        {
            dao = new UsersDAO();
        }

        public bool delete(object obj)
        {
            User user = (User) obj;
            return dao.delete(user);
        }

        public LinkedList<object> find(object obj)
        {
            throw new NotImplementedException(); //todo LinkedList<object> find(object obj)
        }

        public LinkedList<object> getAll()
        {
            return dao.getAll();
        }

        public object getById(int id)
        {
            return dao.getByID(id);
        }

        public bool insert(object obj)
        {
            User user = (User) obj;
            return dao.insert(user);
        }

        public bool update(object obj)
        {
            User user = (User) obj;
            return dao.edit(user);
        }
    }
}