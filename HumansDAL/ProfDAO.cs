using HumansLib.profs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace HumansLib.profs
{
    public class ProfDAO : DAO
    {
        public bool insert(object obj)
        {
            Prof prof = (Prof)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "insert into profs  values";//todo
            try
            {
                conn.Open();
                command.BeginExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool delete(object obj)
        {
            Prof prof = (Prof)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from profs where id=" + prof.id;
            try {
                conn.Open();
                command.BeginExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool edit(object obj)
        {
            Prof prof = (Prof)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from profs where id=" + prof.id;//todo
            try
            {
                conn.Open();
                command.BeginExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public LinkedList<object> getAll()
        {
            throw new NotImplementedException();//todo
        }

        public object getByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
