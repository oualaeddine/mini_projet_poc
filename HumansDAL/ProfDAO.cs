using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Utils;

namespace HumansLib.profs
{
    public class ProfDAO : DAO
    {
        public bool insert(Prof obj)
        {
            Prof prof = (Prof) obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "insert into profs  values"; //todo bool insert(Prof obj)
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

        public bool delete(Prof obj)
        {
            Prof prof = (Prof) obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from profs where id=" + prof.id; //todo bool delete(Prof obj)
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

        public bool edit(Prof obj)
        {
            Prof prof = (Prof) obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from profs where id=" + prof.id; //todo edit(Prof obj)
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

        public LinkedList<Prof> getAll()
        {
            return null; //todo LinkedList<Prof> getAll()
        }

        public Prof getByID(int id)
        {
            return null;
//todo Prof getByID(int id)
        }

        public bool exists(Prof prof, string password)
        {
            return false;
//todo exists(Prof prof, string password)
        }

        public bool ban(Prof prof)
        {
            return false;
//todo bool ban(Prof prof)
        }
    }
}