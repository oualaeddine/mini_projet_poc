using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Utils
{
    public interface IDAO
    {
        MySqlConnection createConnexion();
        bool insert(object obj);
        bool edit(object obj);
        bool delete(object obj);
        LinkedList<object> getAll();
        object getByID(int id);
    }
}
