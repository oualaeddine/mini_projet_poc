using System;
using System.Net;
using System.Net.Mail;
using HumansLib;
using HumansLib.profs;
using OuveragesLib;
using OuvragesCRUD;

namespace BiblioLib.work
{
    public class SysOperImpl : ISystemOper
    {
        public bool banMember(Prof prof)
        {
            return new ProfDAO().ban(prof);
        }

        public bool banMember(Student student)
        {
            return new StudentsDAO().ban(student);
        }

        public bool sendNotif(Human member, int ouvrageId)
        {
            Console.WriteLine("sendNotif({" + member.email + "," + member.nom + "}," + ouvrageId + ")");
            Ouvrage ouvrage = new OuvragesCRUDO().getById(ouvrageId);

            MailMessage mail = new MailMessage("b.v0rt3x@gmail.com",member.email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Credentials = new NetworkCredential("b.v0rt3x@gmail.com", "bdgdhncjxvcfaeae");
            mail.Subject = "Un ouvvrage est disponible !";
            mail.Body = "l'ouvrage : " + ouvrage.title + " de l'auteur " + ouvrage.auteur +
                        " est maintenant disponible vous pouvez le recuperer depuis la bibliotheque";
            client.Send(mail);
            return true;
        }
    }
}