using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Utils
{
    public class DAO : IDAO
    {
       protected MySqlConnection conn;
        static readonly string CONN_STRING = "";

        public DAO()
        {
            this.conn = createConnexion();
        }

        public MySqlConnection createConnexion()
        {
            return new MySqlConnection();
        }

        public bool delete(object obj)
        {
            throw new NotImplementedException();
        }

        public bool edit(object obj)
        {
            throw new NotImplementedException();
        }


        public bool insert(object obj)
        {
            throw new NotImplementedException();
        }


        public object getByID(int id)
        {
            throw new NotImplementedException();
        }

        public LinkedList<object> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
