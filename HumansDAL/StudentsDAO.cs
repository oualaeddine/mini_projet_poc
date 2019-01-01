using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Utils;
using HumansLib.profs;

namespace HumansLib
{
    public class StudentsDAO : DAO, IDAO

    {

        public bool insert(object obj)
        {
            Student prof = (Student)obj;

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
            Student prof = (Student)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from students where id=" + prof.id;
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
        public bool edit(object obj)
        {
            Student prof = (Student)obj;

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

        public LinkedList<object> getAll(object obj)
        {
            throw new NotImplementedException();//todo
        }

        bool exists(Student student, string password)
        {
            throw new NotImplementedException();//todo
        }
    }
}
