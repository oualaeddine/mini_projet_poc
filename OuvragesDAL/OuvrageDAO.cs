using System;
using System.Collections.Generic;
using OuveragesLib;
using Utils;

namespace OuvragesDAL
{
    public class OuvrageDAO : DAO
    {
        public bool delete(Ouvrage obj)
        {
            return false;
            //todo  bool delete(Ouvrage obj)
        }

        public bool edit(Ouvrage obj)
        {
            return false;
            //todo bool edit(Ouvrage obj)
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
            return null;
//todo Ouvrage getByID(int id)
        }

        public bool insert(Ouvrage obj)
        {
            return false;
//todo  bool insert(Ouvrage obj)
        }
    }
}