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
            command.CommandText =
                $"insert into members (nom, prenom, date_naissance, sexe, numero_tel, email, mdp, type) VALUES ({prof.nom},    '{prof.prenom}',    '{prof.dateNaissance}',    '{prof.sexe}',    '{prof.telephone}',    '{prof.email}',    '{prof.password}',    'PROF');INSERT INTO profs (id_member, matricule) VALUES (LAST_INSERT_ID(), '{prof.matricule}');";
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
            command.CommandText = $"delete from profs where id={prof.id}";
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
            command.CommandText =
                $"update members set nom={prof.nom},prenom={prof.prenom},date_naissance={prof.dateNaissance},sexe={prof.sexe},numero_tel={prof.telephone},email={prof.email},mdp={prof.password},type=PROF where id = {prof.id};update profs set matricule = {prof.matricule} where id_member = {prof.id}"; //todo edit(Prof obj)
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

            var profs = new LinkedList<Prof>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        var prof = new Prof
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
                            matricule = reader.GetString(reader.GetOrdinal("matricule"))
                        };
                        profs.AddLast(prof);
                    }

                    reader.Close();
                }
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            return profs;
        }

        public Prof getByID(int id)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from members,profs where profs.id_member= id and id = {id};";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var profs = new LinkedList<Prof>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        return new Prof
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
                            matricule = reader.GetString(reader.GetOrdinal("matricule"))
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

        public bool exists(Prof prof, string password)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from members where email = {prof.email} and password = {password};";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var profs = new LinkedList<Prof>();
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

        public bool ban(Prof prof)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $"insert into bans (id_member, date_banned) VALUES ({prof.id},NOW());";
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