using System;
using System.Collections.Generic;
using System.Data;
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
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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
            try
            {
                if(conn.State.Equals((ConnectionState.Open)))conn.Close();
                conn.Open();
            }
            catch (Exception erro)
            {
                Console.Write("Erro" + erro);
                this.conn.Close();
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT distinct ouvrages.id, "+
            " titre, "+
            " auteur, "+
            " keywords, "+
            " theme, "+
            " n_mat, "+
            " id_ouvrage as isDispo "+
            " from ouvrages "+
            " left join reservations r on ouvrages.id = r.id_ouvrage ;";
            
            var ouvrages = new LinkedList<Ouvrage>();
            var reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    var count = reader.FieldCount;
                    while (reader.Read())
                    {
                        bool isDispon = reader.IsDBNull(reader.GetOrdinal("isDispo"));
                        var ouvrage = new Ouvrage
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            title = reader.GetString(reader.GetOrdinal("titre")),
                            auteur = reader.GetString(reader.GetOrdinal("auteur")),
                            keywords = reader.GetString(reader.GetOrdinal("keywords")),
                            theme = reader.GetString(reader.GetOrdinal("theme")),
                            n_mat = reader.GetString(reader.GetOrdinal("n_mat")),
                            isDisponible = isDispon
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
                if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into reservations (id_member, id_ouvrage, date_reservation)VALUES ({idMember},{ouvrageId},now())"
                , conn);
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
                conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            conn.Close();
            return true;
        }

        public bool isDispo(int ouvrageId)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText =
                $"select * from emprunts,reservations where id_ouvrage = {ouvrageId} and id_reservation = reservations.id;";
            try
            {
                if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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
                        return false;
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

            return true;
        }


        public Human getFirstOuvrageSubscriber(int ouvrageId)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText =
                $"select * from members,reservations where id_ouvrage = {ouvrageId} and id_member = members.id order by date_reservation asc limit 1;";
            try
            {
                if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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

        public bool deleteEmprunt(Ouvrage ouvrage)
        {
            MySqlCommand myCommand2 =
                new MySqlCommand(
                    $"delete from emprunts where (select id from reservations where id_ouvrage ={ouvrage.id}) = id_reservation ;",
                    conn);
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
                conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            conn.Close();

            MySqlCommand myCommand =
                new MySqlCommand(
                    $"delete from reservations where  id =(select id from reservations where id_ouvrage = {ouvrage.id} order by date_reservation  asc limit 1);",
                    conn);
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
                conn.Open();
            var myReader = myCommand.ExecuteReader();
            while (myReader.Read())    
            {
            }

            conn.Close();
            return true;
        }

        public bool insertPret(int idOuvrage, int idMembre)
        {
            MySqlCommand myCommand2 = new MySqlCommand(
                $"insert into emprunts (id_reservation,date_emprunt)VALUES ((select id from reservations where id_ouvrage = {idOuvrage} and id_member =  {idMembre}  order by date_reservation asc  limit 1),now())"
                , conn);
            if(conn.State.Equals((ConnectionState.Open)))conn.Close();
                conn.Open();
            var myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
            }

            conn.Close();
            return true;
        }

        public LinkedList<Ouvrage> find(string search)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from ouvrages " +
                              " where id like '%" + search + "%' " +
                              " or keywords like '%" + search + "%' " +
                              " or theme like '%" + search + "%' " +
                              " or n_mat like '%" + search + "%' " +
                              " or titre like '%" + search + "%'  " +
                              " or auteur like '%" + search + "%' ;";
            try
            {
                if(conn.State.Equals((ConnectionState.Open)))conn.Close();
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

        public bool isDispoForMember(int idOuvrage, int humanId)

        {

            var human = getFirstOuvrageSubscriber(idOuvrage);
           
            return (human != null && humanId == human.id);
        }
    }
}