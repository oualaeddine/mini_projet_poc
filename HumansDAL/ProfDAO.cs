using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Utils;

namespace HumansLib.profs
{
    public class ProfDAO : DAO
    {
        public bool insert(Prof prof)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("inserting " + prof);
            Console.ForegroundColor = ConsoleColor.White;
            string date_naiss = prof.dateNaissance.Year + "/" + prof.dateNaissance.Month + '/' +
                                prof.dateNaissance.Day;
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into members (nom, prenom, date_naissance, sexe, numero_tel, email, mdp, type) VALUES ('{prof.nom}',    '{prof.prenom}',    '{date_naiss}',    '{prof.sexe}',    '{prof.telephone}',    '{prof.email}',    '{prof.password}',    'PROF');INSERT INTO profs (id_member, matricule) VALUES (LAST_INSERT_ID(), '{prof.matricule}');",
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

        public bool delete(Prof obj)
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

        public bool edit(Prof obj)
        {
            Prof prof = (Prof) obj;

            MySqlCommand myCommand2 = new MySqlCommand(
                $"update members set nom={prof.nom},prenom={prof.prenom},date_naissance={prof.dateNaissance},sexe={prof.sexe},numero_tel={prof.telephone},email={prof.email},mdp={prof.password},type=PROF where id = {prof.id};update profs set matricule = {prof.matricule} where id_member = {prof.id}"
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

            this.conn.Close();

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

            this.conn.Close();

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

            this.conn.Close();

            return false;
        }

        public bool ban(Prof prof)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into bans (id_member, date_banned) VALUES ({prof.id},NOW());", conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            myReader2.Close();
            conn.Close();
            return true;
        }

        public LinkedList<Prof> find(string s)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from members,profs " +
                              " where " +
                              "   profs.id_member = id " +
                              "and ( prenom like '%" + s + "%' " +
                              "or email like '%" + s + "%' " +
                              "or id like '%" + s + "%' " +
                              "or matricule like '%" + s + "%') "
                ;
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

            this.conn.Close();

            return profs;
        }

            public Prof findOne(string s)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from members,profs " +
                              " where profs.id_member = id " +
                              "and ( prenom like '%" + s + "%' " +
                              "or email like '%" + s + "%' " +
                              "or id like '%" + s + "%' " +
                              "or matricule like '%" + s + "%') limit 1  ;";       
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        return new Prof()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            nom = reader.GetString(reader.GetOrdinal("nom")),
                            prenom = reader.GetString(reader.GetOrdinal("prenom")),
                            dateNaissance = reader.GetDateTime(reader.GetOrdinal("date_naissance")),
                            sexe = reader.GetString(reader.GetOrdinal("sexe")),
                            telephone = reader.GetString(reader.GetOrdinal("numero_tel")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            password = reader.GetString(reader.GetOrdinal("mdp")),
                            matricule = reader.GetString(reader.GetOrdinal("matricule")),
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

            return null;        }


        public bool isSuspended(int memberId)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText =
                $"select * from bans where id_member = {memberId} and TIMESTAMPDIFF(DAY ,date_banned,now())>30;";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

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