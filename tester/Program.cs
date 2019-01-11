using HumansLib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new Student();
            stu.nom = "poi";

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

            Console.WriteLine(o);
            Console.Read();
        }
    }
}
