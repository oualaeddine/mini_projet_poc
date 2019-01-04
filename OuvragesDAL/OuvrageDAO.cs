using MySql.Data.MySqlClient;
using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace OuvragesDAL
{
    public class OuvrageDAO : DAO
    {
     
        public bool delete(Ouvrage obj)
        {
            throw new NotImplementedException();
        }

        public bool edit(Ouvrage obj)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Ouvrage> getAll()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from ouvrages" ;

            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }
            LinkedList<Ouvrage> ouvrages = new LinkedList<Ouvrage>();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                int count = reader.FieldCount;
                while (reader.Read()) 
                {
                        Ouvrage ouvrage = new Ouvrage();
                        ouvrage.id = reader.GetInt32(0);
                        ouvrage.title = reader.GetString(1);
                        ouvrage.auteur = reader.GetString(2);
                        ouvrage.keywords = reader.GetString(3);
                        ouvrage.theme = reader.GetString(4);
                        ouvrage.n_mat = reader.GetString(5);
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
            throw new NotImplementedException();
        }

        public bool insert(Ouvrage obj)
        {
            throw new NotImplementedException();
        }
    }
}
