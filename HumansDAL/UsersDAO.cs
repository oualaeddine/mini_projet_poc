using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Utils;

namespace HumansLib
{
    public class UsersDAO : DAO
    {
 

        public bool delete(User obj)
        {
            throw new NotImplementedException();//todo delete(User obj)
        }

        public bool edit(User obj)
        {
            throw new NotImplementedException();//todo edit(User obj)
        }

        public LinkedList<User> getAll(User obj)
        {
            throw new NotImplementedException();//todo LinkedList<User> getAll(User obj)
        }

        public User getByID(int id)
        {
            throw new NotImplementedException();//todo  User getByID(int id)
        }

        public bool insert(User obj)
        {
            throw new NotImplementedException();//todo  insert(User obj)
        }
      public  bool exists(User user, string password)
        {
            throw new NotImplementedException();//todo exists(User user, string password)
        }
    
    }
}
