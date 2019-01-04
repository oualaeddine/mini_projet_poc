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

        public bool insert(Student obj)
        {
            Student prof = (Student)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "insert into profs  values";//todo bool insert(Student obj)
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
        public bool delete(Student obj)
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
        public bool edit(Student obj)
        {
            Student prof = (Student)obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = "delete from profs where id=" + prof.id;//todo bool edit(Student obj)
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

        public LinkedList<Student> getAll()
        {
            throw new NotImplementedException();//todo LinkedList<Student> getAll()
        }

        public bool exists(Student student, string password)
        {
            throw new NotImplementedException();//todo exists(Student student, string password)
        }
        public bool ban(Student student)
        {
            throw new NotImplementedException();//todo ban(Student student)
        }

        public Student getByID(int id)
        {
            throw new NotImplementedException();//todo Student getByID(int id)
        }
    }
}
