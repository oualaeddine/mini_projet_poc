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
 

        public bool delete(object obj)
        {
            throw new NotImplementedException();
        }

        public bool edit(object obj)
        {
            throw new NotImplementedException();
        }

        public LinkedList<object> getAll(object obj)
        {
            throw new NotImplementedException();
        }

        public object getByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(object obj)
        {
            throw new NotImplementedException();
        }
        bool exists(User user, string password)
        {
            throw new NotImplementedException();//todo
        }
    }
}
