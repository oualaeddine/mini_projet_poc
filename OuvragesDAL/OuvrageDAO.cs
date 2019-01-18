using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using OuveragesLib;
using Utils;

namespace OuvragesDAL
{
    public class OuvrageDAO : DAO
    {
        public bool delete(Ouvrage obj)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText = $"delete from ouvrages where id={obj.id}";
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

        public bool edit(Ouvrage obj)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $" update ouvrages set auteur='{obj.auteur}',titre='{obj.title}',n_mat='{obj.n_mat}',theme='{obj.theme}',keywords='{obj.keywords}';";
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

        public LinkedList<Ouvrage> getAll()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from ouvrages";
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var ouvrages = new LinkedList<Ouvrage>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        var ouvrage = new Ouvrage
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            title = reader.GetString(reader.GetOrdinal("titre")),
                            auteur = reader.GetString(reader.GetOrdinal("auteur")),
                            keywords = reader.GetString(reader.GetOrdinal("keywords")),
                            theme = reader.GetString(reader.GetOrdinal("theme")),
                            n_mat = reader.GetString(reader.GetOrdinal("n_mat"))
                        };
                        ouvrages.AddLast(ouvrage);
                    }

                    reader.Close();
                }
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            return ouvrages;
        }

        public Ouvrage getByID(int id)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from ouvrages where ouvrages.id = {id};";
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
                        return new Ouvrage()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            title = reader.GetString(reader.GetOrdinal("titre")),
                            auteur = reader.GetString(reader.GetOrdinal("auteur")),
                            keywords = reader.GetString(reader.GetOrdinal("keywords")),
                            theme = reader.GetString(reader.GetOrdinal("theme")),
                            n_mat = reader.GetString(reader.GetOrdinal("n_mat"))
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

        public bool insert(Ouvrage obj)
        {
            MySqlCommand command = this.conn.CreateCommand();
            command.CommandText =
                $"insert into ouvrages (titre, auteur, keywords, theme, n_mat)VALUES ('{obj.title}','{obj.auteur}','{obj.keywords}','{obj.theme}','{obj.n_mat}')";
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