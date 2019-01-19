using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Utils;

namespace HumansLib
{
    public class StudentsDAO : DAO

    {
        public bool insert(Student student)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("inserting student : " + student.niveau);
            Console.ForegroundColor = ConsoleColor.White;
            string date_naiss = student.dateNaissance.Year + "/" + student.dateNaissance.Month + '/' +
                                student.dateNaissance.Day;
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into members (nom, prenom, date_naissance, sexe, numero_tel, email, mdp, type) VALUES ('{student.nom}',    '{student.prenom}',    '{date_naiss}',    '{student.sexe}',    '{student.telephone}',    '{student.email}',    '{student.password}',    'STUDENT');INSERT INTO students (id_member, niveau, n_carte) VALUES (LAST_INSERT_ID(), '{student.niveau}','{student.n_carte}');",
                conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            myReader2.Close();
            conn.Close();
            return true;
        }

        public bool delete(Student obj)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $"delete from members where id={obj.id}", conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            myReader2.Close();
            conn.Close();
            return true;
        }

        public bool edit(Student obj)
        {
            Student student = (Student) obj;

            MySqlCommand myCommand2 = new MySqlCommand(
                $"update members set nom={student.nom},prenom={student.prenom},date_naissance={student.dateNaissance},sexe={student.sexe},numero_tel={student.telephone},email={student.email},mdp={student.password},type=STUDENT where id = {student.id};update students set n_carte = {student.n_carte} , niveau = {student.niveau} where id_member = {student.id}",
                conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            myReader2.Close();
            conn.Close();
            return true;
        }

        public LinkedList<Student> getAll()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from members,students where students.id_member = id;";
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

            this.conn.Close();

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

            this.conn.Close();

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

            this.conn.Close();

            return false;
        }

        public bool ban(Student student)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into bans (id_member, date_banned) VALUES ({student.id},NOW());"
                , conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            myReader2.Close();
            conn.Close();
            return true;
        }
    }
}