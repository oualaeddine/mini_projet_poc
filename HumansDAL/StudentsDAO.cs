using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Utils;

namespace HumansLib
{
    public class StudentsDAO : DAO, IDAO

    {
        public bool insert(Student student)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $"insert into members (nom, prenom, date_naissance, sexe, numero_tel, email, mdp, type) VALUES ({student.nom},    '{student.prenom}',    '{student.dateNaissance}',    '{student.sexe}',    '{student.telephone}',    '{student.email}',    '{student.password}',    'STUDENT');INSERT INTO students (id_member, niveau, n_carte) VALUES (LAST_INSERT_ID(), '{student.niveau}','{student.n_carte}');";

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
            Student student = (Student) obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = $"delete from members where id={student.id}";
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
            Student student = (Student) obj;

            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $"update members set nom={student.nom},prenom={student.prenom},date_naissance={student.dateNaissance},sexe={student.sexe},numero_tel={student.telephone},email={student.email},mdp={student.password},type=STUDENT where id = {student.id};update students set n_carte = {student.n_carte} , niveau = {student.niveau} where id_member = {student.id}"; //todo edit(Prof obj)
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
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from members,profs where profs.id_member = id;";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var students = new LinkedList<Student>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        var stu = new Student()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
                            niveau = reader.GetString(reader.GetOrdinal("niveau")),
                            n_carte = reader.GetString(reader.GetOrdinal("n_carte"))
                        };
                        students.AddLast(stu);
                    }

                    reader.Close();
                }
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            return students;
        }

        public Student getByID(int id)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from members,students where students.id_member = id and id = {id};";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var profs = new LinkedList<Student>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        return new Student()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
                            niveau = reader.GetString(reader.GetOrdinal("niveau")),
                            n_carte = reader.GetString(reader.GetOrdinal("n_carte"))
                        };
                    }

                    reader.Close();
                }
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            return null;
        }


        public bool exists(Student student, string password)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from members where email = {student.email} and password = {password};";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var profs = new LinkedList<Student>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        return true;
                    }

                    reader.Close();
                }
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            return false;
        }

        public bool ban(Student student)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $"insert into bans (id_member, date_banned) VALUES ({student.id},NOW());";
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
    }
}