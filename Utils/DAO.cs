using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Utils
{
    public class DAO : IDAO
    {
        protected MySqlConnection conn;

        static readonly string CONN_STRING =
            "server=localhost;user id=root;persistsecurityinfo=True;database=gestion_biblio";

        public DAO()
        {
            this.conn = createConnexion();
        }

        public MySqlConnection createConnexion()
        {
            return new MySqlConnection(CONN_STRING);
        }

        public bool delete(object obj)
        {
            return false;
        }

        public bool edit(object obj)
        {
            return false;
        }


        public bool insert(object obj)
        {
            return false;
        }


        public object getByID(int id)
        {
            return null;
        }

        public LinkedList<object> getAll()
        {
            return null;
        }
    }
}