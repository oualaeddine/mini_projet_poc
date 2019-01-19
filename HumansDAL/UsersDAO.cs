using System;
using System.Collections.Generic;
using Utils;

namespace HumansLib
{
    public class UsersDAO : DAO
    {
        public bool delete(User obj)
        {
            return false;
//todo delete(User obj)
        }

        public bool edit(User obj)
        {
            return false;
//todo edit(User obj)
        }

        public LinkedList<User> getAll()
        {
            return null;
//todo LinkedList<User> getAll(User obj)
        }

        public User getByID(int id)
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

            var profs = new LinkedList<Student>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        return new User()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
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

        public bool insert(User obj)
        {
            return false;
//todo  insert(User obj)
        }

        public bool exists(User user, string password)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from users where email = {user.email} and password = {password};";
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
    }
}