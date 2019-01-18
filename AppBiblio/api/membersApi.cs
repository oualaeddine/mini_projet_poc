using System;
using System.IO;
using System.Net;
using System.Text;
using AppBiblio.views;
using AppBiblio.views.members;
using HumansLib;
using HumansLib.profs;
using Newtonsoft.Json.Linq;

namespace AppBiblio.api
{
    public class membersApi
    {
        private static readonly string MEMBERS_API_ADD_MEMBER_URL = "http://localhost/ServiceMembersCRUD.svc/add";

        public void addMember(Student stu)
        {
            JObject o = new JObject();
            o["nom"] = stu.nom;
            o["prenom"] = stu.prenom;
            o["sexe"] = stu.sexe;
            o["dateNaiss"] = stu.dateNaissance.ToShortDateString();
            o["telephone"] = stu.telephone;
            o["email"] = stu.email;
            o["adresse"] = stu.adresse;
            o["password"] = stu.password;
            o["n_carte"] = stu.n_carte;
            o["niveau"] = stu.niveau;
            o["type"] = "student";
            sendMember(o.ToString());
        }

        public void addMember(Prof prof)
        {
            JObject o = new JObject();
            o["nom"] = prof.nom;
            o["prenom"] = prof.prenom;
            o["sexe"] = prof.sexe;
            o["dateNaiss"] = prof.dateNaissance.ToShortDateString();
            o["telephone"] = prof.telephone;
            o["email"] = prof.email;
            o["adresse"] = prof.adresse;
            o["password"] = prof.password;
            o["matricule"] = prof.matricule;
            o["type"] = "prof";
            sendMember(o.ToString());
        }

        private void sendMember(string member)
        {
            // create a request
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(MEMBERS_API_ADD_MEMBER_URL);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";

            // turn our request string into a byte stream
            byte[] postBytes = Encoding.UTF8.GetBytes(member);

            // this is important - make sure you specify type this way
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab te response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
        }

        internal void delete(int value, members_list.OnMemberDeleted onMemberDeleted)
        {
            throw new NotImplementedException();
        }

        public void getAll(members_list.OnGetData result)
        {
            throw new NotImplementedException();
        }

        public void trouverMembre(string search, object found)
        {
            //todo
        }
        
    }
}