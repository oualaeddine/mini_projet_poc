using System;
using System.Collections.Generic;
using HumansLib;
using MySql.Data.MySqlClient;
using OuveragesLib;
using Utils;

namespace OuvragesDAL
{
    public class OuvrageDAO : DAO
    {
        public bool delete(int obj)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("deleting ouvrage : " + obj);
            Console.ForegroundColor = ConsoleColor.White;

            MySqlCommand myCommand2 = new MySqlCommand($"delete from ouvrages where id={obj}", conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            conn.Close();
            return true;
        }

        public bool edit(Ouvrage obj)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $" update ouvrages set auteur='{obj.auteur}',titre='{obj.title}',n_mat='{obj.n_mat}',theme='{obj.theme}',keywords='{obj.keywords}';"
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

        public LinkedList<Ouvrage> getAll()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("getAll() ouvrages  ");
            Console.ForegroundColor = ConsoleColor.White;
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

            this.conn.Close();


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

            this.conn.Close();

            return null;
        }

        public bool insert(Ouvrage obj)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into ouvrages (titre, auteur, keywords, theme, n_mat)VALUES ('{obj.title}','{obj.auteur}','{obj.keywords}','{obj.theme}','{obj.n_mat}')"
                , conn);
            conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            conn.Close();
            return true;
        }

        public bool reserver(int idMember, int ouvrageId)
        {
            throw new NotImplementedException();
        }

        public bool isDispo(int ouvrageId)
        {
            throw new NotImplementedException();
        }


        public Human getFirstOuvrageSubscriber(int ouvrageId)
        {
            throw new NotImplementedException();
        }

        public bool deleteEmprunt(Ouvrage ouvrage)
        {
            throw new NotImplementedException();
        }

        public bool insertPret(int idOuvrage, int idMembre)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Ouvrage> find(string search)
        {
            throw new NotImplementedException();
        }
    }
}